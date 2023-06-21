var data=new Time();

data.setHour(3);
data.setMinute(20);
data.setSecond(33);

System.Console.WriteLine(data.getHour);
System.Console.WriteLine(data.getMinute);
System.Console.WriteLine(data.getSecond);

System.Console.WriteLine(data.toString());
data.setTime(59,59,23);
System.Console.WriteLine(data.toString());
data.nextSecond();
System.Console.WriteLine(data.toString());
