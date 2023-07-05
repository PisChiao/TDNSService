# TDNSService
---
## 功能描述

此程序为一项系统服务，会每隔一段时间自动检查自己的IP地址，然后更新DNSPod的解析记录，实现类似DDNS的效果，由于多数路由器不支持DNSPod的DDNS更新，所以可以使用此服务替代。

## 使用方法

1、生成本项目。

2、将Configs文件夹中的文件复制到生成的目录中（Debug或者Release）

3、修改DomainConfig.ini文件中的配置。

4、运行install.ps1把其安装为服务。

## 直接下载已生成版本的使用

1、解压到一个文件夹

2、修改DomainConfig.ini文件中的配置。

3、运行install.ps1把其安装为服务。

## 卸载

1、运行uninstall.ps1

---
# TDNSService

---

## Function Description



This program is a system service that automatically checks its IP address at regular intervals and updates the resolution records of DNSPod, achieving a similar effect to DDNS. Since most routers do not support DDNS updates of DNSPod, this service can be used as a substitute.



## Usage method



1. Generate this project.



2. Copy the files in the Configs folder to the generated directory (Debug or Release)



3. Modify the configuration in the DomainConfig.ini file.



4. Run install.ps1 to install it as a service.



## Download the generated version directly for use



1. Unzip to a folder



2. Modify the configuration in the DomainConfig.ini file.



3. Run install.ps1 to install it as a service.



## Uninstall



1. Run uninstall.ps1