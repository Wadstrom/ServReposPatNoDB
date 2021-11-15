## Övning

I den här övningen tränar vi på Service-Repository-Pattern genom att skapa ett webapi som hanterar böcker och dess bokmärken.

- Skapa ett nytt WebApi med .NET 5.
- Ta bort WeatherForecastController om sådan genererats.
- När du skapar attributen nedan, använd engelsk namnsättning och tänk till vilken typ du tycker varje attribut ska ha.
- Skapa en modell (class) för böcker som har attributen: id, ISBN, titel. (ISBN är ett unikt id för publikationer)
- Skapa en modell för bokmärken som har attributen: Id, en boks id, sidnummer, radnummer.
- Skapa en ny controller i webapi-et som hanterar affärslogik för Böcker.
- Skapa en metod i controllern som syftar till att hämta alla böcker, men lämna metoden tom nu. 

- Använd dig av Service-Repository pattern för att skapa logik som hämtar upp alla böcker. Men i repository-classen räcker det att du skapar upp 
   dumdata och returnerar (dvs du behöver inte koppla mot en databas och göra hämtning eller skriva sql commandon).
   Detta repository ska endast returnera objektet böcker, inte dess bokmärken.

- Gör om stegen ovan för att skapa en metod på samma controller som hämtar upp alla bokmärken. Denna returnerar endast bokmärken och inte böcker.
- Gör en ny metod som hämtar en enskild bok och alla dess bokmärken och returnerar detta som ett enda json-objekt.