dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://api.edenai.run/v2/info/schema

# Strip inline examples (spec is 36MB with examples, ~1MB without)
# Fix wildcard operationIds containing {feature}
# Add top-level security array
python3 -c "
import json, sys
with open('openapi.json') as f:
    spec = json.load(f)

def strip_examples(obj):
    if isinstance(obj, dict):
        for k in list(obj.keys()):
            if k in ('examples', 'example'):
                del obj[k]
            else:
                strip_examples(obj[k])
    elif isinstance(obj, list):
        for item in obj:
            strip_examples(item)

strip_examples(spec)

# Add top-level security
spec['security'] = [{'FeatureApiAuth': []}]

# Fix wildcard operationIds
wildcard = '/{feature}/{subfeature}/batch/{name}/'
if wildcard in spec.get('paths', {}):
    for method, data in spec['paths'][wildcard].items():
        if method in ('get', 'post', 'put', 'patch', 'delete') and 'operationId' in data:
            data['operationId'] = data['operationId'].replace('{feature}', 'feature')

with open('openapi.json', 'w') as f:
    json.dump(spec, f)
print('Spec cleaned and fixed.')
"

autosdk generate openapi.json \
  --namespace EdenAI \
  --clientClassName EdenAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
