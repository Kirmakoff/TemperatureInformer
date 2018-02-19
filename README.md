# TemperatureInformer


This software is used to work with specific logging devices made by Yuwon (a Chinese company):  

![alt text][Logger Photo]

[Logger Photo]: http://www.yuwens.com/ywcn/cn/Upload/image/251.jpg "Logger photo"
This device is supposed to monitor room temperature and send an alarm via SMS when it is too hot or too cold.
Unfortunately, the GSM function in my device does not work at all, so I've decided to write a little workaround.


**TemperatureInformer** reads logs from Yuwese 'Data Logger Graph' folder, and analyzes them.  JSON message is sent immediately if the following is found in logs:
- critical temperature reached in last monitoring cycle, or
- dangerous temperature reached more than 2 times in last 4 monitoring cycles, or
- dangerous temperature reached 1 or more times in last 16 cycles  
 
If nothing dangerous happened, the status message would be sent 2 times in a week (you can change that setting in the configuration file)
