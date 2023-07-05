# 配置文件使用说明
---
1、你需要复制这里的文件到你的Debug目录或者Realease目录，生成的程序会在exe文件所在的目录寻找DomainConfig.ini。

2、install.ps1和uninstall.ps1文件是powershell脚本，分别用来安装系统服务和卸载系统服务，需要用管理员身份运行。

3、运行powershell脚本需要系统允许运行，如果不允许，请在powershell中执行“Set-ExecutionPolicy RemoteSigned”命令，并选择Y。

4、DomainConfig.ini的各种配置信息已经在文件中备注。


# Instructions for using configuration files

---

1. You need to copy the files here to your Debug directory or Realase directory, and the generated program will search for DomainConfig.ini in the directory where the exe file is located.



2. The install.ps1 and uninstall.ps1 files are powershell scripts that are used to install and uninstall system services, respectively, and need to be run as administrators.



3. Running powershell scripts requires system permission. If not, please execute the 'Set ExecutionPolicy RemoteSigned' command in powershell and select Y



4. The various configuration information of DomainConfig.ini has been noted in the file.