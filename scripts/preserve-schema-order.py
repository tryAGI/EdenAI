#!/usr/bin/env python3
"""Keep committed component property order when EdenAI shuffles JSON object keys.

Property order controls positional generated constructors even though it has no
JSON wire meaning. Retain surviving fields in their committed order, append new
fields deterministically, and leave removals and all schema values visible.
"""
import argparse
import copy
import json
from pathlib import Path


def preserve_schema(schema, baseline):
    if not isinstance(schema, dict):
        return 0
    baseline = baseline if isinstance(baseline, dict) else {}
    changed = 0
    properties = schema.get("properties")
    old_properties = baseline.get("properties", {})
    old_properties = old_properties if isinstance(old_properties, dict) else {}
    if isinstance(properties, dict):
        keys = [key for key in old_properties if key in properties]
        keys += sorted(key for key in properties if key not in old_properties)
        changed += list(properties) != keys
        schema["properties"] = {key: properties[key] for key in keys}
        for key, child in schema["properties"].items():
            changed += preserve_schema(child, old_properties.get(key))
    for key in ("items", "additionalProperties", "not"):
        changed += preserve_schema(schema.get(key), baseline.get(key))
    for key in ("allOf", "anyOf", "oneOf"):
        branches = schema.get(key, [])
        old_branches = baseline.get(key, [])
        old_branches = old_branches if isinstance(old_branches, list) else []
        if isinstance(branches, list):
            for index, child in enumerate(branches):
                changed += preserve_schema(child, old_branches[index] if index < len(old_branches) else None)
    return changed


def normalize(spec, baseline):
    original = copy.deepcopy(spec)
    schemas = spec.get("components", {}).get("schemas", {})
    old_schemas = baseline.get("components", {}).get("schemas", {})
    changed = sum(preserve_schema(schema, old_schemas.get(name)) for name, schema in schemas.items())
    # Object-key order is the only permitted change. Lists and all values matter.
    if spec != original:
        raise ValueError("Schema normalization changed a JSON value or removed a field")
    return changed


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("baseline", type=Path)
    parser.add_argument("spec", type=Path)
    args = parser.parse_args()
    baseline = json.loads(args.baseline.read_text())
    spec = json.loads(args.spec.read_text())
    changed = normalize(spec, baseline)
    args.spec.write_text(json.dumps(spec) + "\n")
    print(f"Preserved component property order in {changed} schema objects.")


if __name__ == "__main__":
    main()
