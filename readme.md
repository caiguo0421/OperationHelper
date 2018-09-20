# tomcat文件替换工具

## 新增配置

OperationHelper.exe.config

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <!--tomcat路径-->
    <add key="tomcatHome" value="D:\Apache Software Foundation\apache-tomcat-7.0.82"></add>
    <!-- 待更新经销商（多个经销商用“,”隔开）-->
    <add key="defaultTenant" value="DMJT"></add>
    <!-- 子文件夹路径 -->
    <add key="subPath" value="\WEB-INF\lib\"></add>
    <!--禁止更新的目录-->
    <add key="forbidDirs" value="docs,examples,host-manager,manager,ROOT,DfcvMobile"></add>
  </appSettings>
</configuration>
```

其中forbidDirs为禁止更新的目录



## 强制更新

增加“强制更新”选项

不选中：目录下有相同文件名的文件才更新

选中：强制更新此文件，如果没有则新增

