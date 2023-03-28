# Base62.Conversion

Base conversion is an approach commonly used for URL shorteners. Base conversion helps to convert the same number between its different number representation systems.

The conversion table is `[0-9a-zA-Z]`:

```c#
private const string BASE62 = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
```

The value `999` is converted into `g7` as:

```
999 = 16 * 62^1 + 7 * 62^0 = "g7"
```

where `g` and `7` are the 16th and 7th elements of the `BASE62`.

## Usage

Install:

```
NuGet\Install-Package Base62.Conversion -Version 1.0.0
```

Use:

```c#
var encoded = Base62Converter.Encode(2009215674938); // zn9edcu

var decoded = Base62Converter.Decode("zn9edcu"); // 2009215674938
```

References:

- [Base62 table](https://en.wikipedia.org/wiki/Base62)
- [Base62 Encoder Decoder online tool](https://www.scopulus.co.uk/tools/hexconverter.htm)
- https://www.nuget.org/packages/Base62.Conversion
