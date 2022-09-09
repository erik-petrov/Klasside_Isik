using Klasside_Isik;

Tootaja tootaja = new Tootaja("Aleksei", new DateTime(2004, 4, 27), Isik.sugu.M, Tootaja.Amets.Developer, 1985.0, "Vilde tee 69");
Console.WriteLine(tootaja.ArvutaSissetulek(500, 0.2));
Opilane opilane = new Opilane("Artjom", new DateTime(2003, 11, 13), Isik.sugu.M, Opilane.spec.KeemiaMatemaatika, "9B", "Loksa kool");
Console.WriteLine(opilane.ArvutaVanus());
Kustekooliopilane opilane2 = new Kustekooliopilane("Erik", new DateTime(2004, 12, 22),
    Isik.sugu.M, "TTHK", Kustekooliopilane.Spec.TAR, Kustekooliopilane.Course.Kolmas, 60.0);
opilane2.PrintInfo();