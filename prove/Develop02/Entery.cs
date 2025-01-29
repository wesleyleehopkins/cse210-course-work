public class Entery {
    public string date;

    public string prompt;

    public string response;

    public Entery(string prompt, string date, string response){
        this.date = date;
        this.prompt = prompt;
        this.response = response;

    }

    public string Display(){
        return $"{date} {prompt} {response}";
    }
}