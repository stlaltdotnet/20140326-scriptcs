using System.Net;
using Newtonsoft.Json;
using System.Threading;

WaitHandle waithandle = new ManualResetEvent(true);

while (true) {
  waitHandle.WaitOne();
  Console.WriteLine("what zip code?");
  String zip = Console.ReadLine();
  using (var client = new HttpClient()) {
    try {
      client.GetAsync("http://api.zippopotam.us/us/" + zip)
        .ContinueWith((requestTask) => {
          var response = response = requestTask.Result;
          response.EnsureSuccessStatusCode();
          response.Content.ReadAsStringAsync()
            .ContinueWith((contentTask) => {
              Console.WriteLine(contentTask.Result);
              waitHandle.Set();
            });
        });
    } catch (Exception ex) {
      Console.WriteLine(ex.Message);
      waitHandle.Set();
    }
  }
}
