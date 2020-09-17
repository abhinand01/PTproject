using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

class showList //: IShows_Nf, IShows_Ap */
{
    //List<string> nf_shows=new List<string>(5);
    
    string gen;

    string search_ap, search_nf;
    string[] nf_shows = { "lucifer", "vampire diaries", "FRIENDS", "Stranger Things", "Breaking Bad" };
    string[] ap_shows = { "The Boys", "Mirazpur", "Big Bang Theory", "Bandish Bandits", "**Comicstaan**" };
    int flag=0;
    public void shows_Nf () {
        
     using (StreamReader r = new StreamReader("netflix.json"))
    {
        string json = r.ReadToEnd();
        dynamic array=JsonConvert.DeserializeObject(json);
        foreach(var item in array.movie)
        {
        //List<string> temp = new List<string>();
        Console.WriteLine(item.name);
        }
    }    
    }
    public void findyourshow(string selectgenre)
    {
         using (StreamReader r = new StreamReader("series.json"))
    {
        string json = r.ReadToEnd();
        dynamic array=JsonConvert.DeserializeObject(json);
        string gn1;
        string gn2;
        foreach(var item in array.input)
        {
            gn1=item.genre;
            gn2=item.genre1;
            if(selectgenre==gn1 || selectgenre==gn2)
            {
                Console.WriteLine("Serie name:"+item.name);
                Console.WriteLine("genre:"+item.genre+","+item.genre1);
                Console.WriteLine("IMDB Rating:"+item.Rating);
                Console.WriteLine("Story line:"+item.Storyline+"\n\n");
                flag=1;
            }

        }
        if(flag==0)
        Console.WriteLine("sorry.......");
    }
    }
    public void findyourshow(double a)
    {
         using (StreamReader r = new StreamReader("series.json"))
    {
        string json = r.ReadToEnd();
        dynamic array=JsonConvert.DeserializeObject(json);
         foreach(var item in array.input)
            {
            double imdb=item.Rating;
            //double imdb=double.Parse(imdb1);
            if(imdb>=a)
            {
                Console.WriteLine("Serie name:"+item.name);
                Console.WriteLine("genre:"+item.genre+","+item.genre1);
                Console.WriteLine("IMDB Rating:"+item.Rating);
                Console.WriteLine("Story line:"+item.Storyline+"\n\n");
                flag=1; 
            }
            }
            if(flag==0)
             Console.WriteLine("sorry......");
    }

    }
    public void select_Nf_genre () {
 
           //Console.WriteLine("enter your genre");
           //gen=Console.ReadLine();
          // findyourshow(gen);
           Console.WriteLine("Minimum rating you need");
         double rate=Convert.ToDouble(Console.ReadLine());
           findyourshow(rate);
           }
    public void search_Nf_shows () {
           using (StreamReader r = new StreamReader("series.json"))
    {
        string json = r.ReadToEnd();
        dynamic array=JsonConvert.DeserializeObject(json);
        Console.WriteLine("Enter the serie name");
        string name=Console.ReadLine();
        foreach(var item in array.input)
        {
            string name2=item.name;
            if(name==name2){
                Console.WriteLine("Found.......!\n");
                 Console.WriteLine(item.name);
                 Console.WriteLine(item.genre);
        flag=1;
        }
        }
        if(flag==0)
        Console.WriteLine("Show is not available");
    }
       

    }
    public void select_Ap_genre () {
      
    }
    public void shows_Ap () {
        Console.WriteLine ("----Shows in Amazon Prime----");
        for (int i = 0; i < 5; i++)
            Console.WriteLine (ap_shows[i]);
    }
    public void search_Ap_shows () {
        int flag = 0;
        Console.WriteLine ("Enter the show that you are looking for:");
        search_ap = Console.ReadLine ();
        //int s_ap = Int32.Parse(search_ap);
        for (int i = 0; i < 5; i++) {
            if (ap_shows[i] == search_ap) {
                flag = 1;
                break;
            }

        }
        if (flag == 1)
            Console.WriteLine ("The Show is available..Enjoy Watching....");
        else
            Console.WriteLine ("Sry the Show is not Available");
    }
}