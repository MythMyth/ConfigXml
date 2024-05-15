// See https://aka.ms/new-console-template for more information

using System.Xml;

Console.WriteLine("Hello, World!");

XmlDocument doc = new XmlDocument();
XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
doc.AppendChild(docNode);

XmlNode body = doc.CreateElement("body");
doc.AppendChild(body);

XmlNode UD1 = doc.CreateElement("ud1");
body.AppendChild(UD1);
XmlText ud1Text = doc.CreateTextNode("XXXX");
UD1.AppendChild(ud1Text);

XmlNode UD2 = doc.CreateElement("ud2");
body.AppendChild (UD2);
XmlText ud2Text = doc.CreateTextNode("XXXX");
UD2.AppendChild(ud2Text);

XmlNode UD3 = doc.CreateElement("ud3");
body.AppendChild(UD3);
XmlText ud3Text = doc.CreateTextNode("XXXX");
UD3.AppendChild(ud3Text);

XmlNode UD4 = doc.CreateElement("ud4");
body.AppendChild(UD4);
XmlText ud4Text = doc.CreateTextNode("XXXX");
UD4.AppendChild(ud4Text);

XmlNode CmdSpeed = doc.CreateElement("cmdspd");
body.AppendChild(CmdSpeed);
XmlText cmdSpeedText = doc.CreateTextNode("10");
CmdSpeed.AppendChild(cmdSpeedText);

XmlNode DataSpeed = doc.CreateElement("dataspd");
body.AppendChild(DataSpeed);
XmlText dataSpeed = doc.CreateTextNode("10");
DataSpeed.AppendChild(dataSpeed);

XmlNode Compression = doc.CreateElement("compress");
body.AppendChild(Compression);
XmlText compressText = doc.CreateTextNode("XZ");
Compression.AppendChild(compressText);

XmlNode DataFormat = doc.CreateElement("format");
body.AppendChild(DataFormat);
XmlText dataFormatText = doc.CreateTextNode("RGB");
DataFormat.AppendChild(dataFormatText);

XmlNode UploadX = doc.CreateElement("x");
body.AppendChild(UploadX);
XmlText xVal = doc.CreateTextNode("0");
UploadX.AppendChild(xVal);

XmlNode UploadY = doc.CreateElement("y");
body.AppendChild(UploadY);
XmlText yVal = doc.CreateTextNode("0");
UploadY.AppendChild(yVal);

XmlNode BaseName = doc.CreateElement("name");
body.AppendChild(BaseName);
XmlText name = doc.CreateTextNode("image");
BaseName.AppendChild(name);

XmlNode BaseNameIndex = doc.CreateElement("index");
body.AppendChild(BaseNameIndex);
XmlText index = doc.CreateTextNode("1");
BaseNameIndex.AppendChild(index);

XmlNode LoadedList = doc.CreateElement("list");
body.AppendChild(LoadedList);

doc.Save("config.xml");