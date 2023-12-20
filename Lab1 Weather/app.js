let weather = 
{
  apiKey: "2edb891504a4aba85d525f7a119893c4",
    fetchWeather: function (city)
    {
        fetch( "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=" + this.apiKey)
        .then((response) => response.json())
        .then((data) => this.displayWeather(data));
    },

    displayWeather: function (data)
    {
        const { temp, feels_like, temp_min, temp_max, pressure, humidity } = data.main;
        const { icon, description } = data.weather[0];
        const { speed } = data.wind;
        const { name } = data;

        console.log(name, icon, description, temp, humidity, speed);

        document.querySelector(".temp").innerText = temp + "°C";
        document.querySelector(".city").innerHTML = "Погода в " + name;
        document.querySelector(".description").innerText = description;
        document.querySelector(".icon").src = "http://openweathermap.org/img/wn/" + icon + "@2x.png";
        document.querySelector(".feelslike").innerText = "Ощущается как: " + feels_like + "°C || Макс: " + temp_max + "°C || Мин: " + temp_min + "°C";
        document.querySelector(".pressure").innerText = "Давление: " + pressure + "pa || Влажность: " + humidity + "% || Скорость ветра: " + speed + "км/ч";
    },

    search: function ()
    {
        this.fetchWeather(document.querySelector(".search-bar").value);
    },
};

document.querySelector(".search button").addEventListener("click", function ()
{
    weather.search();
});
