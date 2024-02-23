var dirPath = args[0];
Console.Write(dirPath);
var reader = new ExifLib.ExifReader(dirPath);
reader.GetTagValue<double[]>(ExifLib.ExifTags.GPSLatitude, out var gpsLatitude);
reader.GetTagValue<string>(ExifLib.ExifTags.GPSLatitudeRef, out var latRef);
reader.GetTagValue<double[]>(ExifLib.ExifTags.GPSLongitude, out var gpsLongitude);
reader.GetTagValue<string>(ExifLib.ExifTags.GPSLongitudeRef, out var longRef);
var latArr = gpsLatitude.Select(oo => oo.ToString()).ToArray();
var hasil = $@"{latArr[0]}°{latArr[1]}'{latArr[2]}""{latRef}";
var longArr = gpsLongitude.Select(oo => oo.ToString()).ToArray();
var hasil02 = $@"{longArr[0]}°{longArr[1]}'{longArr[2]}""{longRef}";
var coord = $"{hasil}+{hasil02}";
var something = $@"https://www.google.com/maps/place/{coord}";

var aPro = new System.Diagnostics.Process();
aPro.StartInfo.FileName = something;
aPro.StartInfo.UseShellExecute = true;
aPro.Start();