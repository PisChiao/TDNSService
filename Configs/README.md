# �����ļ�ʹ��˵��
---
1������Ҫ����������ļ������DebugĿ¼����RealeaseĿ¼�����ɵĳ������exe�ļ����ڵ�Ŀ¼Ѱ��DomainConfig.ini��

2��install.ps1��uninstall.ps1�ļ���powershell�ű����ֱ�������װϵͳ�����ж��ϵͳ������Ҫ�ù���Ա������С�

3������powershell�ű���Ҫϵͳ�������У��������������powershell��ִ�С�Set-ExecutionPolicy RemoteSigned�������ѡ��Y��

4��DomainConfig.ini�ĸ���������Ϣ�Ѿ����ļ��б�ע��


# Instructions for using configuration files

---

1. You need to copy the files here to your Debug directory or Realase directory, and the generated program will search for DomainConfig.ini in the directory where the exe file is located.



2. The install.ps1 and uninstall.ps1 files are powershell scripts that are used to install and uninstall system services, respectively, and need to be run as administrators.



3. Running powershell scripts requires system permission. If not, please execute the 'Set ExecutionPolicy RemoteSigned' command in powershell and select Y



4. The various configuration information of DomainConfig.ini has been noted in the file.