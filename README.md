# TDNSService
---
## 功能描述

此程序为一项系统服务，会每隔一段时间自动检查自己的IP地址，然后更新DNSPod的解析记录，实现类似DDNS的效果，由于多数路由器不支持DNSPod的DDNS更新，所以可以使用此服务替代。

## 使用方法

1、生成本项目。

2、将Configs文件夹中的文件复制到生成的目录中（Debug或者Realse）

3、修改DomainConfig.ini文件中的配置。

4、运行install.ps1把其安装为服务。

## 直接下载已生成版本的使用

1、解压到一个文件夹

2、修改DomainConfig.ini文件中的配置。

3、运行install.ps1把其安装为服务。

## 卸载

1、运行uninstall.ps1