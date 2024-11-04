﻿namespace _11._04_;

internal class Versenyzo
{
    public string Nev { get; set; }
    public int Szul { get; set; }
    public string RajtSzam { get; set; }
    public bool Nem { get; set; }
    public string Kategoria { get; set; }
    public Dictionary<string, TimeSpan> Versenyido { get; set; }

    public override string ToString() => $"[{RajtSzam}] {Nev} ({(Nem ? "ferfi" : "nő")}, {Kategoria})";

    public int OsszIdoSec => (int)Versenyido.Values.Sum(x => x.TotalSeconds);

    public Versenyzo(string sor) {
        string[] v = sor.Split(';');
        Nev = v[0];
        Szul = int.Parse(v[1]);
        RajtSzam = v[2];
        Nem = v[3] == "f";
        Kategoria = v[4];
        Versenyido = new() {
            {"úszás",       TimeSpan.Parse(v[5])},
            {"I. depó",     TimeSpan.Parse(v[6])},
            {"kerékpár",    TimeSpan.Parse(v[7])},
            {"II. depó",    TimeSpan.Parse(v[8])},
            {"futás",       TimeSpan.Parse(v[9])},
        };
    }
}
