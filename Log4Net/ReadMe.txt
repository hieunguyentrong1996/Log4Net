1. Cai dat package Log4Net
2. Trong AssemblyInfo
	+ Cau hinh: [assembly: log4net.Config.XmlConfigurator(Watch =true)]
3. Cau hinh App.Config
	<configSections>
    <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler,Log4net"/>
    </configSections>
      <log4net>
        <appender name="TestAppender" type="log4net.Appender.RollingFileAppender">
          <file value="D:\Hieu.Nguyen\Console\log\MyTestAppender.log"/>
          <encoding value="utf-8" />
          <appendToFile value="true"/>
          <rollingStyle value="Date"/>

          <!--<rollingStyle value="Size"/>
          <maxSizeRollBackups value="5"/>
          <staticLogFileName value="true"/>-->
          <layout type="log4net.Layout.PatternLayout">
            <conversionPattern value="%date %level [%thread] %type.%method - %message%n"/>
          </layout>
        </appender>
        <root>
          <level value="All"/>
          <appender-ref ref="TestAppender"/>
        </root>
      </log4net>
4. Khoi tao 
    + private static readonly ILog Log4Net = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    + Viet ham su dung log4net
    + Goi ham