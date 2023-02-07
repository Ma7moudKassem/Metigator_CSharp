using System.Reflection;

Type type = typeof(Program);
Assembly assembly = type.Assembly;

Stream? streem = assembly.GetManifestResourceStream(type, "Phones.json");

if (streem is null) return;
byte[] data = new BinaryReader(streem).ReadBytes((int)streem.Length);

foreach (byte da in data)
{
    Console.WriteLine((char)da);
    System.Threading.Thread.Sleep(300);
}
streem.Close()