# TDNSService
---
## ��������

�˳���Ϊһ��ϵͳ���񣬻�ÿ��һ��ʱ���Զ�����Լ���IP��ַ��Ȼ�����DNSPod�Ľ�����¼��ʵ������DDNS��Ч�������ڶ���·������֧��DNSPod��DDNS���£����Կ���ʹ�ô˷��������

## ʹ�÷���

1�����ɱ���Ŀ��

2����Configs�ļ����е��ļ����Ƶ����ɵ�Ŀ¼�У�Debug����Release��

3���޸�DomainConfig.ini�ļ��е����á�

4������install.ps1���䰲װΪ����

## ֱ�����������ɰ汾��ʹ��

1����ѹ��һ���ļ���

2���޸�DomainConfig.ini�ļ��е����á�

3������install.ps1���䰲װΪ����

## ж��

1������uninstall.ps1

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