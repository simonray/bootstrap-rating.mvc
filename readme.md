#bootstrap-rating.mvc (C# / MVC) [![nuget package](https://img.shields.io/nuget/v/bootstrap-rating.mvc.png?style=flat-square)](https://www.nuget.org/profiles/simonray)

A Html Helper wrapper for the jQuery [bootstrap-rating](https://github.com/dreyescat/bootstrap-rating) plug-in.

To install, run the following command in the Package Manager Console.

```csharp
Install-Package bootstrap-rating.mvc
```

## Configuration
Add the following css

```html
<link href="~/Content/bootstrap-rating.css" rel="stylesheet" />
```

and script to your project
```html
<script src="~/Scripts/bootstrap-rating/bootstrap-rating.min.js"></script>
```
>

## Usage
You're now ready to start using the control.

```csharp
@Html.BootstrapRating(m => m.RatingValue)[.Start][.Step][...]
```

## Examples
[Download](http://github.com/simonray/bootstrap-rating.mvc/zipball/master/)

## Change Log

### 1.0.0 (19-02-15)
- Initial Release.

## Acknowledgements

* [bootstrap-rating](https://github.com/dreyescat/bootstrap-rating/)
