import copy
import importlib.util
from pathlib import Path
import unittest

module_spec = importlib.util.spec_from_file_location("schema_order", Path(__file__).parents[1] / "preserve-schema-order.py")
module = importlib.util.module_from_spec(module_spec)
module_spec.loader.exec_module(module)


class SchemaOrderTests(unittest.TestCase):
    def normalize(self, before, after):
        spec = {"components": {"schemas": {"Model": after}}}
        baseline = {"components": {"schemas": {"Model": before}}}
        original = copy.deepcopy(spec)
        module.normalize(spec, baseline)
        self.assertEqual(original, spec)
        return spec["components"]["schemas"]["Model"]

    def test_preserves_positional_constructor_provider_order(self):
        before = {"properties": {"openai": {"$ref": "#/Data"}, "amazon": {"$ref": "#/Data"}}}
        after = {"properties": dict(reversed(list(before["properties"].items())))}
        result = self.normalize(before, after)
        self.assertEqual(["openai", "amazon"], list(result["properties"]))

    def test_appends_new_fields_without_reordering_existing_fields(self):
        result = self.normalize({"properties": {"z": {}, "a": {}}}, {"properties": {"new_z": {}, "a": {}, "new_a": {}, "z": {}}})
        self.assertEqual(["z", "a", "new_a", "new_z"], list(result["properties"]))

    def test_keeps_removed_fields_removed_and_changed_values(self):
        result = self.normalize({"properties": {"removed": {}, "kept": {"type": "string"}}}, {"properties": {"kept": {"type": "integer"}}})
        self.assertEqual({"kept": {"type": "integer"}}, result["properties"])

    def test_preserves_nested_property_order_and_property_named_properties(self):
        before = {"properties": {"properties": {"type": "object", "properties": {"z": {}, "a": {}}}}}
        after = {"properties": {"properties": {"type": "object", "properties": {"a": {}, "z": {}}}}}
        result = self.normalize(before, after)
        self.assertEqual(["z", "a"], list(result["properties"]["properties"]["properties"]))

    def test_recurses_through_schema_composition_items_and_additional_properties(self):
        for key in ["allOf", "anyOf", "oneOf", "items", "additionalProperties", "not"]:
            with self.subTest(key=key):
                old = {"properties": {"z": {}, "a": {}}}
                new = {"properties": {"a": {}, "z": {}}}
                before = {key: [old] if key in ["allOf", "anyOf", "oneOf"] else old}
                after = {key: [new] if isinstance(before[key], list) else new}
                result = self.normalize(before, after)[key]
                result = result[0] if isinstance(result, list) else result
                self.assertEqual(["z", "a"], list(result["properties"]))

    def test_keeps_required_arrays_descriptions_examples_and_extensions(self):
        before = {"properties": {"z": {}, "a": {}}}
        after = {"properties": {"a": {}, "z": {}}, "required": ["a", "z"], "description": "new docs", "example": {"properties": {"a": 1, "z": 2}}, "x-provider": {"properties": {"a": 1, "z": 2}}}
        result = self.normalize(before, after)
        self.assertEqual(["a", "z"], result["required"])
        self.assertEqual(["a", "z"], list(result["example"]["properties"]))
        self.assertEqual(["a", "z"], list(result["x-provider"]["properties"]))

    def test_new_schema_is_deterministic_and_normalization_is_idempotent(self):
        after = {"properties": {"z": {}, "a": {}}}
        result = self.normalize({}, after)
        self.assertEqual(["a", "z"], list(result["properties"]))
        self.assertEqual(result, self.normalize(result, copy.deepcopy(result)))

    def test_boolean_additional_properties_and_missing_components(self):
        self.normalize({"additionalProperties": False}, {"additionalProperties": True})
        self.assertEqual(0, module.normalize({}, {}))


if __name__ == "__main__":
    unittest.main()
