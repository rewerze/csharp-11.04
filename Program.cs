using _11._04_;
using System.Text;

List<Versenyzo> versenyzok = [];

using StreamReader sr = new("..\\..\\..\\src\\forras.txt", Encoding.UTF8);
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"{versenyzok.Count}");





Console.WriteLine("\n\n\t-----------------");
Console.WriteLine("\t|    1. csopi   |");
Console.WriteLine("\t-----------------\n\n");

var f1 = versenyzok.Count(v => v.Kategoria == "elit");
Console.WriteLine($"Versenyzők elit száma: {f1}");

var f2 = versenyzok.Where(v => !v.Nem).Average(v => DateTime.Now.Year - v.Szul);
Console.WriteLine($"Női versenyzők átlag életkora: {f2:0.00}");

var f3 = versenyzok.Sum(v => v.Versenyido["kerékpár"].TotalHours);
Console.WriteLine($"kerékpározással tölött összidő: {f3:0.00} óra");

var f4 = versenyzok.Where(v => v.Kategoria == "elit junior").Average(v => v.Versenyido["úszás"].TotalMinutes);
Console.WriteLine($"elit junior átlagos úszási ideje: {f4:0.00} perc");

var f5 = versenyzok.Where(v => v.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"férfi győztes: {f5}");

var f6 = versenyzok.GroupBy(v => v.Kategoria).OrderBy(g => g.Key);
Console.WriteLine($"versenyt befejezők száma (kategória, fő, depo ido):");
foreach (var grp in f6) Console.WriteLine(
    $"{grp.Key,11}: " +
    $"{grp.Count(),2} fő | " +
    $"avg depo: {grp.Average(v => v.Versenyido["I. depó"].TotalMinutes + v.Versenyido["II. depó"].TotalMinutes):0.000} perc");





Console.WriteLine("\n\n\t-----------------");
Console.WriteLine("\t|    2. csopi   |");
Console.WriteLine("\t-----------------\n\n");

var f7 = versenyzok.Count(v => v.Kategoria == "elit junior");
Console.WriteLine($"Versenyzők elit junior száma: {f7}");

var f8 = versenyzok.Where(v => v.Nem).Average(v => DateTime.Now.Year - v.Szul);
Console.WriteLine($"Férfi versenyzők átlag életkora: {f8:0.00}");

var f9 = versenyzok.Sum(v => v.Versenyido["futás"].TotalHours);
Console.WriteLine($"futással tölött összidő: {f9:0.00} óra");

var f10 = versenyzok.Where(v => v.Kategoria == "20-24").Average(v => v.Versenyido["úszás"].TotalMinutes);
Console.WriteLine($"20-24 átlagos úszási ideje: {f10:0.00} perc");

var f11 = versenyzok.Where(v => !v.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"női győztes: {f11}");

var f12 = versenyzok.GroupBy(v => v.Nem ? "Férfi" : "Nő").OrderBy(g => g.Key);
Console.WriteLine($"versenyt befejezők száma (nem, fő, depo ido):");
foreach (var grp in f12) Console.WriteLine(
    $"{grp.Key,5}: " +
    $"{grp.Count(),2} fő | " +
    $"avg depo: {grp.Average(v => v.Versenyido["I. depó"].TotalMinutes + v.Versenyido["II. depó"].TotalMinutes):0.000} perc");






Console.WriteLine("\n\n\t-----------------");
Console.WriteLine("\t|    3. csopi   |");
Console.WriteLine("\t-----------------\n\n");

var f13 = versenyzok.Count(v => v.Kategoria == "25-29");
Console.WriteLine($"Versenyzők 25-29 korosok száma: {f13}");

var f14 = versenyzok.Average(v => DateTime.Now.Year - v.Szul);
Console.WriteLine($"Versenyzők átlag életkora: {f14:0.00}");

var f15 = versenyzok.Sum(v => v.Versenyido["úszás"].TotalHours);
Console.WriteLine($"úszás tölött összidő: {f15:0.00} óra");

var f16 = versenyzok.Where(v => v.Kategoria == "elit").Average(v => v.Versenyido["úszás"].TotalMinutes);
Console.WriteLine($"elit átlagos úszási ideje: {f16:0.00} perc");

var f17 = versenyzok.Where(v => v.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"férfi győztes: {f17}");

var f18 = versenyzok.GroupBy(v => v.Kategoria).OrderBy(g => g.Key);
Console.WriteLine($"versenyt befejezők száma (kategória, fő, depo ido):");
foreach (var grp in f18) Console.WriteLine(
    $"{grp.Key,11}: " +
    $"{grp.Count(),2} fő | " +
    $"avg depo: {grp.Average(v => v.Versenyido["I. depó"].TotalMinutes + v.Versenyido["II. depó"].TotalMinutes):0.000} perc");