# EdenAI schema normalization

The provider can shuffle component `properties` dictionaries without changing
JSON semantics. AutoSDK uses their order for public model constructors. Many
response constructors take the same CLR type for every provider, so reordering
silently changes positional calls while preserving the binary signature.

`generate.sh` captures the committed spec before downloading the next one.
`preserve-schema-order.py` keeps surviving component fields in that baseline
order, appends new fields deterministically, and recurses through nested schemas.
It does not restore removed fields or change types, required lists, documentation,
examples or provider extensions. New/removal API changes still need normal release
compatibility review. Generated C# is always emitted by AutoSDK.

Run `python3 -m unittest discover -s scripts/tests -v` for normalization fixtures.
The offline `LegacyProviderConstructorOrderIsStable` integration test also checks
representative existing positional contracts without credentials or network calls.
