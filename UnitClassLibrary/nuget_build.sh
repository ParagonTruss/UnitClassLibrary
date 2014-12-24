cd "UnitClassLibrary"
rm *.nupkg
STAMP="$(date +%s)"
nuget pack UnitClassLibrary.csproj -Version 1.1.$STAMP