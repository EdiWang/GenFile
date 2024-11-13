# GenFile

Generate test file at given size

## Install

Requires [.NET 8.0 SDK](https://dot.net)

```powershell
dotnet tool install -g GenFile
```

## Usage

### As .NET Tool or Standalone Executable

```powershell
Description:
  Generate test file at given size

Usage:
  GenFile.DotNetTool [options]

Options:
  -d, --directory <directory>  Output directory. [default: .]
  -f, --filename <filename>    Output filename. [default: testfile.dat]
  -s, --size <size>            Output file size (B, KB, MB, GB). e.g. 996MB [default: 251MB]
  --version                    Show version information
  -?, -h, --help               Show help and usage information
```

Example:

```powershell
PS C:\Users\Edi> genfile
Generating 'testfile.dat' at '.' with size '251MB'...
File generated.
```

```powershell
PS C:\Users\Edi> genfile -s "1GB" -d "D:\" -f "test.dat"
Generating 'test.dat' at 'D:\' with size '1GB'...
File generated.
```

## 免责申明

GenFile 及其配套组件均为免费开源的产品，仅用于学习交流，并且不直接向中国提供服务，中国访客请于下载后立即删除。

任何中国境内的组织及个人不得使用 GenFile 及其配套组件构建任何形式的面向中国境内访客的网站或服务。

不可用于任何违反中华人民共和国(含台湾省)或使用者所在地区法律法规的用途。

因为作者即本人仅完成代码的开发和开源活动(开源即任何人都可以下载使用)，从未参与访客的任何运营和盈利活动。

且不知晓访客后续将程序源代码用于何种用途，故访客使用过程中所带来的任何法律责任即由访客自己承担。

[《开源软件有漏洞，作者需要负责吗？是的！》](https://go.edi.wang/aka/os251)