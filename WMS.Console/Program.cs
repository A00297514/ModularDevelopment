﻿using WMS.Library;
using WMS.Library.Interface;


        WeatherData weatherData = WeatherData.Instance;
        
        // Subscribe observers to WeatherData
        weatherData.Subscribe(new CurrentConditionsDisplay());
        weatherData.Subscribe(new StatisticsDisplay());
        weatherData.Subscribe(new ForecastDisplay());

        // Simulate weather changes
        Random rand = new Random();
        int temperature = rand.Next(-50,50);
        weatherData.setTemperature(temperature);

       
    