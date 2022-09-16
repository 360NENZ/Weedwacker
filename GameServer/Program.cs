
using KcpTunnel;

var tokenSource = new CancellationTokenSource();
string connectIp = "127.0.0.1";
int connectPort = 22102;
string listenIp = "0.0.0.0";
int listenPort = 22102;
await KcpTunnelClientProgram.RunAsync($"{connectIp}:{connectPort}", $"{listenIp}:{listenPort}", 1400, tokenSource.Token);
Console.ReadLine(); // wait here (later make this be console command handler)