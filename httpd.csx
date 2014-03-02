using System;
using System.Net;

using (HttpListener listener = new HttpListener()) {
  listener.Prefixes.Add("http://+:8080/");
  listener.Start();
  while (true) {
    HttpListenerContext context = listener.GetContext();
    HttpListenerRequest req = context.Request;
    HttpListenerResponse res = context.Response;

    Console.WriteLine(req.HttpMethod + " " + req.RawUrl);
    String payload = "<h1>Hello, world! You requested: %1</h1>".Replace("%1", req.RawUrl);
    Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(payload);
    res.ContentLength64 = buffer.Length;

    System.IO.Stream output = res.OutputStream;
    output.Write(buffer, 0, buffer.Length);
    output.Close();
  }
}