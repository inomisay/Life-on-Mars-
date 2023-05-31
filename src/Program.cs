// Framework: .NET 7.0

// using file operations
using System;
using System.IO;

// create the file
//StreamWriter file = File.CreateText("dna1.txt");

/* ********************************* */
char[] mainStrand = Array.Empty<char>(), auxillaryStrand_2 = Array.Empty<char>(), auxillaryStrand_3 = Array.Empty<char>();

string read1 = " ", read2 = " ", read3 = " ";

char[] Strand1 = new char[200];
char[] Strand2 = new char[200];

// Amino acid - DNA Codons
string[] Ala = { "GCT", "GCC", "GCA", "GCG" };
string[] Arg = { "CGT", "CGC", "CGA", "CGG", "AGA", "AGG" };
string[] Asn = { "AAT", "AAC" };
string[] Asp = { "GAT", "GAC" };
string[] Cys = { "TGT", "TGC" };
string[] Gln = { "CAA", "CAG" };
string[] Glu = { "GAA", "GAG" };
string[] Gly = { "GGT", "GGC", "GGA", "GGG" };
string[] His = { "CAT", "CAC" };
string[] Ile = { "ATT", "ATC", "ATA" };
string[] Leu = { "CTT", "CTC", "CTA", "CTG", "TTA", "TTG" };
string[] Lys = { "AAA", "AAG" };
string Met_Start_Codons = "ATG";
string[] Phe = { "TTT", "TTC" };
string[] Pro = { "CCT", "CCC", "CCA", "CCG" };
string[] Ser = { "TCT", "TCC", "TCA", "TCG", "AGT", "AGC" };
string[] Thr = { "ACT", "ACC", "ACA", "ACG" };
string Trp = "TGG";
string[] Tyr = { "TAT", "TAC" };
string[] Val = { "GTT", "GTC", "GTA", "GTG" };
string[] Stop_Codons = { "TAA", "TGA", "TAG" };

char[] startcodon = { 'A', 'T', 'G' };
char[] stopCodon1 = { 'T', 'A', 'A' };
char[] stopCodon2 = { 'T', 'G', 'A' };
char[] stopCodon3 = { 'T', 'A', 'G' };

int two_hydrogenBond = 0, three_hydrogenBond = 0, sum_hydrogenBond = 0;

int operationstrand = 0;
int controlForOp4 = 0;                                                                                     

/* ********************************* */

// Menu

int operation;
Boolean menuflag = false;

while (!menuflag)
{
    Thread.Sleep(1500);
    Console.WriteLine("\n✶ BLOB OPERATION MENU ON MARS ✶");
    Console.WriteLine("\n/* ********************************* */\n");
    Console.WriteLine("1- Operation1\n2- Operation2\n3- Operation3\n4- Operation4\n" +
        "5- Operation5\n6- Operation6\n7- Operation7\n8- Operation8\n9- Operation9\n" +
        "10- Operation10\n11- Operation11\n12- Operation12\n13- Operation13\n" +
        "14- Operation14\n15- Operation15\n16- Operation16\n17- Operation17\nEnter 0 to exit from program.\n");

    while (true) // Controls the switch case entries
    {
        Console.Write("\nPlease enter your Operation number: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out operation))
            break;
        else
            Console.Write("\nYour entry is invalid. Please Try again!\n");
    }
    switch (operation)
    {
        case 1: // Load a DNA sequence from a file
            try
            {
                controlForOp4 = 1;
                Console.Write("\nPlease write your DNA file: ");
                string txt = Console.ReadLine(); //"dna1.txt"
                StreamReader file = File.OpenText(txt);

                // read the first line
                read1 = file.ReadLine();

                mainStrand = new char[read1.Length];

                // getting the string character by character
                for (int i = 0; i < read1.Length; i++)
                {
                    mainStrand[i] = read1[i];
                }
                Console.Write("\nDNA Strand : ");
                Space();
                Console.Write("\n");
                Console.Write("\nDNA Main Strand has been loaded and ready to use.\n");

                // close the file
                file.Close();
            }
            catch
            {
                Console.Write("\n");
                Console.WriteLine("\nNo document found by that name! \nPlease make sure your file is in the right document.\n");
            }
            break;
        case 2: //Load a DNA sequence from a string
            Console.WriteLine("\n✶ DNA Strands ✶");
            Console.WriteLine("\n1- Main Strand\n2- Auxiliary Strand-2\n3- Auxiliary Strand-3");

            while (true)
            {
                Console.Write("\nPlease choose a DNA Strand to Load: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out operationstrand))
                    break;
                else
                    Console.Write("\n");
                    Console.Write("Your entry is invalid. Please Try again!\n");
            }
            switch (operationstrand)
            {
                case 1:
                    Console.Write("\nPlease enter your DNA sequence: ");
                    read1 = Console.ReadLine().ToUpper(); //Example: ("ATGAAAGGGTAGATGAAATAG");
                    mainStrand = new char[read1.Length];

                    bool control_DNA_1 = control_function();

                    if (control_DNA_1 == true)
                    {
                        for (int i = 0; i < read1.Length; i++)  // getting the string character by character
                        {
                            mainStrand[i] = read1[i];
                        }
                        Console.Write("\nDNA Strand : ");
                        Space();
                        Console.Write("\n");
                        Console.Write("\nDNA Main Strand has been saved.\n");
                        controlForOp4 = 2;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter valid nucleotides...\n");
                    }
                    break;
                case 2:
                    Console.Write("\nPlease enter your DNA sequence: ");
                    read2 = Console.ReadLine().ToUpper(); //Example: ("ATGTTTTTTTAGATGAGCTAG");
                    auxillaryStrand_2 = new char[read2.Length];

                    bool control_DNA_2 = control_function();

                    if (control_DNA_2 == true)
                    {
                        for (int i = 0; i < read2.Length; i++)  // getting the string character by character
                        {
                            auxillaryStrand_2[i] = read2[i];
                        }
                        Console.Write("\nDNA Strand : ");
                        Space();
                        Console.Write("\n");
                        Console.Write("\nDNA Main Strand has been saved.\n");
                        controlForOp4 = 3;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter valid nucleotides...\n");
                    }
                    break;
                case 3:
                    Console.Write("\nPlease enter your DNA sequence: ");
                    read3 = Console.ReadLine().ToUpper(); //Example: ("ATGACTGATGAGAGATATTGA");
                    auxillaryStrand_3 = new char[read3.Length];

                    bool control_DNA_3 = control_function();

                    if (control_DNA_3 == true)
                    {
                        for (int i = 0; i < read3.Length; i++)  // getting the string character by character
                        {
                            auxillaryStrand_3[i] = read3[i];
                        }
                        Console.Write("\nDNA Strand : ");
                        Space();
                        Console.Write("\n");
                        Console.Write("\nDNA Main Strand has been saved.\n");
                        controlForOp4 = 4;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter valid nucleotides...\n");
                    }
                    break;
            }
            break;
        case 3: // Generate random DNA sequence o a BLOB
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                Random rand = new Random();
                int x = rand.Next(0, 2);
                if (x == 0)
                {
                    Console.Write("BLOB's newborn's Male gene: ");
                    Generate_BLOB_newborn_male();
                    Console.Write("\n");
                    Console.Write("\n");

                }

                else if (x == 1)
                {
                    Console.Write("BLOB's newborn's Female gene: ");
                    Generate_BLOB_newborn_female();
                    Console.Write("\n");
                    Console.Write("\n");

                }
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 4: // Check DNA gene structure !!!!!!
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                GeneStructure();
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 5: // Check DNA of BLOB organisim !!!!!!
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                BLOB_Organisim();
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 6: // Produce complement of a DNA sequence
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                complement();
                Console.Write("\n");

            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 7: // Determine amino acids
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                aminoacids();
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 8: // Delete codons 
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                deleteCodons();
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 9: // Insert codons
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                insertCodons();
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 10: // Find codons
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                Space();
                Console.WriteLine("\n");
                findCondons();
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 11: // Reverse codons
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                reverseCodons();
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 12: // Find the number of genes in a DNA strad (BLOB or not)
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                geneNumber();
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 13: // Find the shortest gene in a DNA strand
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                shortestGene();
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 14: // Find the longest gene in a DNA strand
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                longestGene();
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 15: // Find the most repeated n-nucleotide sequence in a DNA strand (STR - Short Tandem Repeat)
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                repeated_nucleotide();
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 16: // Hydrogen Bond statistics for a DNA strand
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                Console.Write("DNA Strand : ");
                Space();
                Console.WriteLine("\n");
                HydrogenBond();
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 17: // Simulate BLOB generations using DNA strand 1 and 2  (DNA strand 3 is for the newborn)
            if (mainStrand.Length != 0 || auxillaryStrand_2.Length != 0 || auxillaryStrand_3.Length != 0)
            {
                Console.WriteLine("\n");
                BLOB_Generations();
            }
            else
            {
                Console.WriteLine("\n/* ********************************* */");
                Console.WriteLine("\nNo DNA strand. Please pick one first.\n");
                Console.WriteLine("/* ********************************* */\n");
                break;
            }
            break;
        case 0:
            menuflag = true;
            Console.WriteLine("\nThe program has been closed!");
            break;
        default:
            Console.Write("Your entry is invalid. Please Try again!\n");
            break;
    }
}

// Functions

// Operation 3
void Generate_BLOB_newborn_female()
{
    Random rnd = new Random();

    // randomly selecting the stop codons
    int index_stopCodons = rnd.Next(Stop_Codons.Length);

    // middle genes
    string[] femalegenderGene = { "AAA", "TTT" };

    // randomly selecting middle codons - second codon
    int index_middleCodons_1 = rnd.Next(femalegenderGene.Length);

    // randomly selecting middle codons - third codon
    int index_middleCodons_2 = rnd.Next(femalegenderGene.Length);

    // other codons 
    string[] otherCodon = new string[] { "A", "T", "C", "G" };

    // Generating String for other codons
    string concencrate = "";

    string mainconcencrate = "";

    /// New born baby DNA
    string newBornGene_female = Met_Start_Codons + femalegenderGene[index_middleCodons_1] + femalegenderGene[index_middleCodons_2] + Stop_Codons[index_stopCodons];

    // Randomly selecting the number of  other codons in a gene from 1 to 4
    int randomNumbOfCodons = rnd.Next(1, 5);
    int genderRand = rnd.Next(1, 6);
    for (int h = 0; h < genderRand; h++)
    {
        mainconcencrate = "";
        concencrate = "";
        for (int i = 0; i <= randomNumbOfCodons; i++)
        {

            for (int j = 0; j < 3; j++)
            {
                // randomly selecting codons
                int index_otherCodons = rnd.Next(otherCodon.Length);
                concencrate += otherCodon[index_otherCodons];

            }
            for (int x = 0; x < concencrate.Length - 3; x += 3)
            {
                if ((concencrate[x] == startcodon[0] && concencrate[x + 1] == startcodon[1] && concencrate[x + 2] == startcodon[2]) || (concencrate[x] == stopCodon1[0] && concencrate[x + 1] == stopCodon1[1] && concencrate[x + 2] == stopCodon1[2]) || (concencrate[x] == stopCodon2[0] && concencrate[x + 1] == stopCodon2[1] && concencrate[x + 2] == stopCodon2[2]) || (concencrate[x] == stopCodon3[0] && concencrate[x + 1] == stopCodon3[1] && concencrate[x + 2] == stopCodon3[2]))
                {
                    concencrate = "CGA";
                }
            }


        }

        mainconcencrate = concencrate;
        newBornGene_female += Met_Start_Codons + mainconcencrate + Stop_Codons[index_stopCodons];
    }

    // AAA or TTT = X ---- GGG or CCC = Y
    // gender ? XX female ---- XY or YX male
    if ((femalegenderGene[index_middleCodons_1] == "AAA" || femalegenderGene[index_middleCodons_1] == "TTT") && (femalegenderGene[index_middleCodons_2] == "AAA" || femalegenderGene[index_middleCodons_2] == "TTT"))
    {

        int count = 1;
        for (int i = 1; i <= newBornGene_female.Length; i++)
        {
            char a = newBornGene_female[i - 1];
            Console.Write(a);
            while (count % 3 == 0)
            {
                Console.Write(" ");
                break;
            }
            count++;
        }
    }

}

void Generate_BLOB_newborn_male()
{
    Random rnd = new Random();

    // randomly selecting the stop codons
    int index_stopCodons = rnd.Next(Stop_Codons.Length);

    // middle genes
    string[] malegenderGene = { "AAA", "TTT", "GGG", "CCC" };

    // randomly selecting middle codons - second codon
    int index_middleCodons_1 = rnd.Next(malegenderGene.Length);

    // randomly selecting middle codons - third codon
    int index_middleCodons_2 = rnd.Next(malegenderGene.Length);

    // other codons
    string[] otherCodon = new string[] { "A", "T", "C", "G" };

    // Generating String for other codons
    string concencrate = "";
    string mainconcencrate = "";

    /// New born baby DNA
    string newBornGene_male = Met_Start_Codons + malegenderGene[index_middleCodons_1] + malegenderGene[index_middleCodons_2] + Stop_Codons[index_stopCodons];
    while (true)
    {
        if ((malegenderGene[index_middleCodons_1] == "GGG" || malegenderGene[index_middleCodons_1] == "CCC") && (malegenderGene[index_middleCodons_2] == "GGG" || malegenderGene[index_middleCodons_2] == "CCC"))
        {
            index_middleCodons_1 = rnd.Next(malegenderGene.Length);
            index_middleCodons_2 = rnd.Next(malegenderGene.Length);
            newBornGene_male = Met_Start_Codons + malegenderGene[index_middleCodons_1] + malegenderGene[index_middleCodons_2] + Stop_Codons[index_stopCodons];
        }
        else if ((malegenderGene[index_middleCodons_1] == "TTT" || malegenderGene[index_middleCodons_1] == "AAA") && (malegenderGene[index_middleCodons_2] == "TTT" || malegenderGene[index_middleCodons_2] == "AAA"))
        {
            index_middleCodons_1 = rnd.Next(malegenderGene.Length);
            index_middleCodons_2 = rnd.Next(malegenderGene.Length);
            newBornGene_male = Met_Start_Codons + malegenderGene[index_middleCodons_1] + malegenderGene[index_middleCodons_2] + Stop_Codons[index_stopCodons];
        }
        else
            break;
    }


    // Randomly selecting the number of  other codons in a gene from 1 to 4
    int randomNumbOfCodons = rnd.Next(1, 5);
    int genderRand = rnd.Next(1, 6);
    for (int h = 0; h < genderRand; h++)
    {
        mainconcencrate = "";
        concencrate = "";
        for (int i = 0; i <= randomNumbOfCodons; i++)
        {

            for (int j = 0; j < 3; j++)
            {
                // randomly selecting codons
                int index_otherCodons = rnd.Next(otherCodon.Length);
                concencrate += otherCodon[index_otherCodons];

            }
            for (int x = 0; x < concencrate.Length - 3; x += 3)
            {
                if ((concencrate[x] == startcodon[0] && concencrate[x + 1] == startcodon[1] && concencrate[x + 2] == startcodon[2]) || (concencrate[x] == stopCodon1[0] && concencrate[x + 1] == stopCodon1[1] && concencrate[x + 2] == stopCodon1[2]) || (concencrate[x] == stopCodon2[0] && concencrate[x + 1] == stopCodon2[1] && concencrate[x + 2] == stopCodon2[2]) || (concencrate[x] == stopCodon3[0] && concencrate[x + 1] == stopCodon3[1] && concencrate[x + 2] == stopCodon3[2]))
                {
                    concencrate = "CGA";
                }
            }


        }

        mainconcencrate = concencrate;
        newBornGene_male += Met_Start_Codons + mainconcencrate + Stop_Codons[index_stopCodons];
    }

    // AAA or TTT = X ---- GGG or CCC = Y
    // gender ? XX female ---- XY or YX male
    if (((malegenderGene[index_middleCodons_1] == "AAA" || malegenderGene[index_middleCodons_1] == "TTT") && (malegenderGene[index_middleCodons_2] == "CCC" || malegenderGene[index_middleCodons_2] == "GGG")) || ((malegenderGene[index_middleCodons_1] == "CCC" || malegenderGene[index_middleCodons_1] == "GGG") && (malegenderGene[index_middleCodons_2] == "AAA" || malegenderGene[index_middleCodons_2] == "TTT")))
    {

        int count = 1;
        for (int i = 1; i <= newBornGene_male.Length; i++)
        {
            char a = newBornGene_male[i - 1];
            Console.Write(a);
            while (count % 3 == 0)
            {
                Console.Write(" ");
                break;
            }
            count++;
        }
    }
}

// Operation 4
void GeneStructure()
{
    bool flag = false;
    bool flag2 = true;

    if (mainStrand.Length != 0)
    {
        if (mainStrand[0] == 'A' && mainStrand[1] == 'T' && mainStrand[2] == 'G')
            flag = true;

        if ((mainStrand[mainStrand.Length - 1] == 'A' && mainStrand[mainStrand.Length - 2] == 'A' && mainStrand[mainStrand.Length - 3] == 'T'))
            flag = true;
        else if ((mainStrand[mainStrand.Length - 1] == 'A' && mainStrand[mainStrand.Length - 2] == 'G' && mainStrand[mainStrand.Length - 3] == 'T'))
            flag = true;
        else if ((mainStrand[mainStrand.Length - 1] == 'G' && mainStrand[mainStrand.Length - 2] == 'A' && mainStrand[mainStrand.Length - 3] == 'T'))
            flag = true;
        else
            flag = false;

        for (int i = 3; i < mainStrand.Length - 2; i = i + 3)
        {
            if (mainStrand[i] == 'A' && mainStrand[i + 1] == 'T' && mainStrand[i + 2] == 'G')
                flag = false;
        }
        if (((mainStrand[mainStrand.Length - 2] == ' ' || mainStrand[mainStrand.Length - 3] == ' ') && ((mainStrand[mainStrand.Length - 1] == 'T') || (mainStrand[mainStrand.Length - 1] == 'A') || (mainStrand[mainStrand.Length - 1] == 'G') || (mainStrand[mainStrand.Length - 1] == 'C'))))
            flag = false;
        else if (mainStrand.Length % 3 != 0)
            flag = false;

        for (int i = 0; i <= mainStrand.Length - 2; i += 3)
        {
            while (mainStrand[i] == 'A' && mainStrand[i + 1] == 'T' && mainStrand[i + 2] == 'G')
            {
                if ((mainStrand[i + 3] == 'T') && ((mainStrand[i + 4] == stopCodon1[1] && mainStrand[i + 5] == stopCodon1[2]) ||
                    (mainStrand[i + 4] == stopCodon2[1] && mainStrand[i + 5] == stopCodon2[2]) || (mainStrand[i + 4] == stopCodon3[1] &&
                    mainStrand[i + 5] == stopCodon3[2])))
                {
                    Console.Write("DNA Strand : ");
                    Space();
                    Thread.Sleep(1000);
                    Console.Write("\n");
                    Console.WriteLine("\nGene structure is OK. (Not BLOB DNA, but OK)");
                    flag2 = false;

                    break;
                }
                break;
            }
            if (flag2 == false)
                break;
        }
        if (flag == true)
        {
            Console.Write("DNA Strand : ");
            Space();
            Thread.Sleep(1000);
            Console.Write("\n");
            Console.WriteLine("\nGene structure is OK.");
        }
        else if (flag2 == true && flag == false)
        {
            Console.Write("DNA Strand : ");
            Space();
            Thread.Sleep(1000);
            Console.Write("\n");
            Console.WriteLine("\nGene structure error.");
        }
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        if (auxillaryStrand_2[0] == 'A' && auxillaryStrand_2[1] == 'T' && auxillaryStrand_2[2] == 'G')
        {
            flag = true;
        }
        if ((auxillaryStrand_2[auxillaryStrand_2.Length - 1] == 'A' && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == 'A' && auxillaryStrand_2[auxillaryStrand_2.Length - 3] == 'T'))
            flag = true;
        else if ((auxillaryStrand_2[auxillaryStrand_2.Length - 1] == 'A' && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == 'G' && auxillaryStrand_2[auxillaryStrand_2.Length - 3] == 'T'))
            flag = true;
        else if ((auxillaryStrand_2[auxillaryStrand_2.Length - 1] == 'G' && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == 'A' && auxillaryStrand_2[auxillaryStrand_2.Length - 3] == 'T'))
            flag = true;
        else
            flag = false;

        for (int i = 3; i < auxillaryStrand_2.Length - 2; i = i + 3)
        {
            if (auxillaryStrand_2[i] == 'A' && auxillaryStrand_2[i + 1] == 'T' && auxillaryStrand_2[i + 2] == 'G')
            {
                flag = false;
            }
        }
        if (((auxillaryStrand_2[auxillaryStrand_2.Length - 2] == ' ' || auxillaryStrand_2[auxillaryStrand_2.Length - 3] == ' ') && ((auxillaryStrand_2[auxillaryStrand_2.Length - 1] == 'T') || (auxillaryStrand_2[auxillaryStrand_2.Length - 1] == 'A') || (auxillaryStrand_2[auxillaryStrand_2.Length - 1] == 'G') || (auxillaryStrand_2[auxillaryStrand_2.Length - 1] == 'C'))))
            flag = false;
        else if (auxillaryStrand_2.Length % 3 != 0)
            flag = false;
        for (int i = 0; i <= auxillaryStrand_2.Length - 2; i += 3)
        {
            while (auxillaryStrand_2[i] == 'A' && auxillaryStrand_2[i + 1] == 'T' && auxillaryStrand_2[i + 2] == 'G')
            {
                if ((auxillaryStrand_2[i + 3] == 'T') && ((auxillaryStrand_2[i + 4] == stopCodon1[1] && auxillaryStrand_2[i + 5] == stopCodon1[2]) ||
                    (auxillaryStrand_2[i + 4] == stopCodon2[1] && auxillaryStrand_2[i + 5] == stopCodon2[2]) || (auxillaryStrand_2[i + 4] == stopCodon3[1] &&
                    auxillaryStrand_2[i + 5] == stopCodon3[2])))
                {
                    Console.Write("DNA Strand : ");
                    Space();
                    Thread.Sleep(1000);
                    Console.Write("\n");
                    Console.WriteLine("\nGene structure is OK. (Not BLOB DNA, but OK)");
                    flag2 = false;

                    break;
                }
                break;
            }
            if (flag2 == false)
                break;
        }
        if (flag == true)
        {
            Console.Write("DNA Strand : ");
            Space();
            Thread.Sleep(1000);
            Console.Write("\n");
            Console.WriteLine("\nGene structure is OK.");
        }
        else if (flag2 == true && flag == false)
        {
            Console.Write("DNA Strand : ");
            Space();
            Thread.Sleep(1000);
            Console.Write("\n");
            Console.WriteLine("\nGene structure error.");
        }
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        if (auxillaryStrand_3[0] == 'A' && auxillaryStrand_3[1] == 'T' && auxillaryStrand_3[2] == 'G')
        {
            flag = true;
        }
        if ((auxillaryStrand_3[auxillaryStrand_3.Length - 1] == 'A' && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == 'A' && auxillaryStrand_3[auxillaryStrand_3.Length - 3] == 'T'))
            flag = true;
        else if ((auxillaryStrand_3[auxillaryStrand_3.Length - 1] == 'A' && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == 'G' && auxillaryStrand_3[auxillaryStrand_3.Length - 3] == 'T'))
            flag = true;
        else if ((auxillaryStrand_3[auxillaryStrand_3.Length - 1] == 'G' && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == 'A' && auxillaryStrand_3[auxillaryStrand_3.Length - 3] == 'T'))
            flag = true;
        else
            flag = false;

        for (int i = 3; i < auxillaryStrand_3.Length - 2; i = i + 3)
        {
            if (auxillaryStrand_3[i] == 'A' && auxillaryStrand_3[i + 1] == 'T' && auxillaryStrand_3[i + 2] == 'G')
            {
                flag = false;
            }
        }
        if (((auxillaryStrand_3[auxillaryStrand_3.Length - 2] == ' ' || auxillaryStrand_3[auxillaryStrand_3.Length - 3] == ' ') && ((auxillaryStrand_3[auxillaryStrand_3.Length - 1] == 'T') || (auxillaryStrand_3[auxillaryStrand_3.Length - 1] == 'A') || (auxillaryStrand_3[auxillaryStrand_3.Length - 1] == 'G') || (auxillaryStrand_3[auxillaryStrand_3.Length - 1] == 'C'))))
            flag = false;
        else if (auxillaryStrand_3.Length % 3 != 0)
            flag = false;
        for (int i = 0; i <= auxillaryStrand_3.Length - 2; i += 3)
        {
            while (auxillaryStrand_3[i] == 'A' && auxillaryStrand_3[i + 1] == 'T' && auxillaryStrand_3[i + 2] == 'G')
            {
                if ((auxillaryStrand_3[i + 3] == 'T') && ((auxillaryStrand_3[i + 4] == stopCodon1[1] && auxillaryStrand_3[i + 5] == stopCodon1[2]) ||
                    (auxillaryStrand_3[i + 4] == stopCodon2[1] && auxillaryStrand_3[i + 5] == stopCodon2[2]) || (auxillaryStrand_3[i + 4] == stopCodon3[1] &&
                    auxillaryStrand_3[i + 5] == stopCodon3[2])))
                {
                    Console.Write("DNA Strand : ");
                    Space();
                    Thread.Sleep(1000);
                    Console.Write("\n");
                    Console.WriteLine("\nGene structure is OK. (Not BLOB DNA, but OK)");
                    flag2 = false;

                    break;
                }
                break;
            }
            if (flag2 == false)
                break;
        }
        if (flag == true)
        {
            Console.Write("DNA Strand : ");
            Space();
            Thread.Sleep(1000);
            Console.Write("\n");
            Console.WriteLine("\nGene structure is OK.");
        }
        else if (flag2 == true && flag == false)
        {
            Console.Write("DNA Strand : ");
            Space();
            Thread.Sleep(1000);
            Console.Write("\n");
            Console.WriteLine("\nGene structure error.");
        }
    }
}

// Operation 5
void BLOB_Organisim()
{
    if (mainStrand.Length != 0)
    {
        bool controlFlag = false;

        for (int i = 0; i < 9; i = i + 3)
        {
            if ((mainStrand[i] == stopCodon1[0] && mainStrand[i + 1] == stopCodon1[1] && mainStrand[i + 2] == stopCodon1[2]) ||
                (mainStrand[i] == stopCodon2[0] && mainStrand[i + 1] == stopCodon2[1] && mainStrand[i + 2] == stopCodon2[2]) ||
                (mainStrand[i] == stopCodon3[0] && mainStrand[i + 1] == stopCodon3[1] && mainStrand[i + 2] == stopCodon3[2]))
            {
                Console.Write("DNA Strand : ");
                Space();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                Console.WriteLine("\nGender error.");
                controlFlag = true;
            }
        }
        if (((mainStrand[3] != mainStrand[4]) || (mainStrand[3] != mainStrand[5]) || (mainStrand[6] != mainStrand[7]) || (mainStrand[6] != mainStrand[8])) &&
        (mainStrand[0] == 'A' && mainStrand[1] == 'T' && mainStrand[2] == 'G' && mainStrand[9] == 'T') && (((mainStrand[10] == stopCodon1[1])
        && (mainStrand[11] == stopCodon1[2])) || ((mainStrand[10] == stopCodon2[1]) && (mainStrand[11] == stopCodon2[2])) || ((mainStrand[10] == stopCodon3[1]) && (mainStrand[11] == stopCodon3[2])))
        && (mainStrand[12] == 'A' && mainStrand[13] == 'T' && mainStrand[14] == 'G')
        && ((mainStrand[mainStrand.Length - 1] == stopCodon1[2] && mainStrand[mainStrand.Length - 2] == stopCodon1[1] &&
        mainStrand[mainStrand.Length - 3] == stopCodon1[0]) || (mainStrand[mainStrand.Length - 1] == stopCodon2[2] && mainStrand[mainStrand.Length - 2] == stopCodon2[1] &&
        mainStrand[mainStrand.Length - 3] == stopCodon2[0]) || (mainStrand[mainStrand.Length - 1] == stopCodon3[2] && mainStrand[mainStrand.Length - 2] == stopCodon3[1] &&
        mainStrand[mainStrand.Length - 3] == stopCodon3[0])))
        {
            Console.Write("DNA Strand : ");
            Space();
            Thread.Sleep(1000);
            Console.WriteLine("\n");
            Console.WriteLine("\nGender error.");
        }
        else if ((mainStrand[3] != mainStrand[4]) || (mainStrand[3] != mainStrand[5]) || (mainStrand[6] != mainStrand[7]) || (mainStrand[6] != mainStrand[8]) &&
        !((mainStrand[0] == 'A' && mainStrand[1] == 'T' && mainStrand[2] == 'G' && mainStrand[9] == 'T') && ((mainStrand[10] == stopCodon1[1])
        || (mainStrand[10] == stopCodon2[1]) || (mainStrand[10] == stopCodon3[1])) && ((mainStrand[11] == stopCodon1[2]) || (mainStrand[11] == stopCodon2[2]) || (mainStrand[11] == stopCodon3[2])) &&
        ((mainStrand[3] == mainStrand[4]) && (mainStrand[3] == mainStrand[5]) && (mainStrand[6] == mainStrand[7]) && (mainStrand[6] == mainStrand[8])) && (mainStrand[12] == 'A' && mainStrand[13] == 'T' && mainStrand[14] == 'G')
        && ((mainStrand[mainStrand.Length - 1] == stopCodon1[2] && mainStrand[mainStrand.Length - 2] == stopCodon1[1] &&
        mainStrand[mainStrand.Length - 3] == stopCodon1[0]) || (mainStrand[mainStrand.Length - 1] == stopCodon2[2] && mainStrand[mainStrand.Length - 2] == stopCodon2[1] &&
        mainStrand[mainStrand.Length - 3] == stopCodon2[0]) || (mainStrand[mainStrand.Length - 1] == stopCodon3[2] && mainStrand[mainStrand.Length - 2] == stopCodon3[1] &&
        mainStrand[mainStrand.Length - 3] == stopCodon3[0]))))
        {
            if (controlFlag == false)
            {
                Console.Write("DNA Strand : ");
                Space();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                Console.WriteLine("\nGender error. Number of genes error.");
            }
        }
        if ((mainStrand[0] == 'A' && mainStrand[1] == 'T' && mainStrand[2] == 'G' && mainStrand[9] == 'T') && ((mainStrand[10] == stopCodon1[1])
        || (mainStrand[10] == stopCodon2[1]) || (mainStrand[10] == stopCodon3[1])) && ((mainStrand[11] == stopCodon1[2]) || (mainStrand[11] == stopCodon2[2]) || (mainStrand[11] == stopCodon3[2])) &&
        ((mainStrand[3] == mainStrand[4]) && (mainStrand[3] == mainStrand[5]) && (mainStrand[6] == mainStrand[7]) && (mainStrand[6] == mainStrand[8]))
        && ((mainStrand[mainStrand.Length - 1] == stopCodon1[2] && mainStrand[mainStrand.Length - 2] == stopCodon1[1] &&
        mainStrand[mainStrand.Length - 3] == stopCodon1[0]) || (mainStrand[mainStrand.Length - 1] == stopCodon2[2] && mainStrand[mainStrand.Length - 2] == stopCodon2[1] &&
        mainStrand[mainStrand.Length - 3] == stopCodon2[0]) || (mainStrand[mainStrand.Length - 1] == stopCodon3[2] && mainStrand[mainStrand.Length - 2] == stopCodon3[1] &&
        mainStrand[mainStrand.Length - 3] == stopCodon3[0])))
        {
            if (mainStrand.Length > 14)
            {
                if ((mainStrand[12] == 'A' && mainStrand[13] == 'T' && mainStrand[14] == 'G'))
                {
                    if (mainStrand.Length > 18)
                    {
                        if (!((stopCodon1[0] == mainStrand[15] && stopCodon1[1] == mainStrand[16] && stopCodon1[2] == mainStrand[17])
                        || (stopCodon2[0] == mainStrand[15] && stopCodon2[1] == mainStrand[16] && stopCodon2[2] == mainStrand[17])
                        || (stopCodon3[0] == mainStrand[15] && stopCodon3[1] == mainStrand[16] && stopCodon3[2] == mainStrand[17])))
                        {
                            Console.Write("DNA Strand : ");
                            Space();
                            Thread.Sleep(1000);
                            Console.WriteLine("\n");
                            Console.WriteLine("\nBLOB is OK.");
                        }
                    }
                    else
                    {
                        Console.Write("DNA Strand : ");
                        Space();
                        Thread.Sleep(1000);
                        Console.WriteLine("\n");
                        Console.WriteLine("\nNumber of codons error.");
                    }
                }
                else
                {
                    Console.Write("DNA Strand : ");
                    Space();
                    Thread.Sleep(1000);
                    Console.WriteLine("\nNumber of genes error.");
                }
            }
            else
            {
                Console.Write("DNA Strand : ");
                Space();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                Console.WriteLine("\nNumber of genes error.");
            }
        }
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        bool controlFlag = false;

        for (int i = 0; i < 9; i = i + 3)
        {
            if ((auxillaryStrand_2[i] == stopCodon1[0] && auxillaryStrand_2[i + 1] == stopCodon1[1] && auxillaryStrand_2[i + 2] == stopCodon1[2]) ||
                (auxillaryStrand_2[i] == stopCodon2[0] && auxillaryStrand_2[i + 1] == stopCodon2[1] && auxillaryStrand_2[i + 2] == stopCodon2[2]) ||
                (auxillaryStrand_2[i] == stopCodon3[0] && auxillaryStrand_2[i + 1] == stopCodon3[1] && auxillaryStrand_2[i + 2] == stopCodon3[2]))
            {
                Console.Write("DNA Strand : ");
                Space();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                Console.WriteLine("\nGender error.");
                controlFlag = true;
            }
        }
        if (((auxillaryStrand_2[3] != auxillaryStrand_2[4]) || (auxillaryStrand_2[3] != auxillaryStrand_2[5]) || (auxillaryStrand_2[6] != auxillaryStrand_2[7]) || (auxillaryStrand_2[6] != auxillaryStrand_2[8])) &&
        (auxillaryStrand_2[0] == 'A' && auxillaryStrand_2[1] == 'T' && auxillaryStrand_2[2] == 'G' && auxillaryStrand_2[9] == 'T') && (((auxillaryStrand_2[10] == stopCodon1[1])
        && (auxillaryStrand_2[11] == stopCodon1[2])) || ((auxillaryStrand_2[10] == stopCodon2[1]) && (auxillaryStrand_2[11] == stopCodon2[2])) || ((auxillaryStrand_2[10] == stopCodon3[1]) && (auxillaryStrand_2[11] == stopCodon3[2])))
        && (auxillaryStrand_2[12] == 'A' && auxillaryStrand_2[13] == 'T' && auxillaryStrand_2[14] == 'G')
        && ((auxillaryStrand_2[auxillaryStrand_2.Length - 1] == stopCodon1[2] && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == stopCodon1[1] &&
        auxillaryStrand_2[auxillaryStrand_2.Length - 3] == stopCodon1[0]) || (auxillaryStrand_2[auxillaryStrand_2.Length - 1] == stopCodon2[2] && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == stopCodon2[1] &&
        auxillaryStrand_2[auxillaryStrand_2.Length - 3] == stopCodon2[0]) || (auxillaryStrand_2[auxillaryStrand_2.Length - 1] == stopCodon3[2] && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == stopCodon3[1] &&
        auxillaryStrand_2[auxillaryStrand_2.Length - 3] == stopCodon3[0])))
        {
            Console.Write("DNA Strand : ");
            Space();
            Thread.Sleep(1000);
            Console.WriteLine("\n");
            Console.WriteLine("\nGender error.");
        }
        else if ((auxillaryStrand_2[3] != auxillaryStrand_2[4]) || (auxillaryStrand_2[3] != auxillaryStrand_2[5]) || (auxillaryStrand_2[6] != auxillaryStrand_2[7]) || (auxillaryStrand_2[6] != auxillaryStrand_2[8]) &&
        !((auxillaryStrand_2[0] == 'A' && auxillaryStrand_2[1] == 'T' && auxillaryStrand_2[2] == 'G' && auxillaryStrand_2[9] == 'T') && ((auxillaryStrand_2[10] == stopCodon1[1])
        || (auxillaryStrand_2[10] == stopCodon2[1]) || (auxillaryStrand_2[10] == stopCodon3[1])) && ((auxillaryStrand_2[11] == stopCodon1[2]) || (auxillaryStrand_2[11] == stopCodon2[2]) || (auxillaryStrand_2[11] == stopCodon3[2])) &&
        ((auxillaryStrand_2[3] == auxillaryStrand_2[4]) && (auxillaryStrand_2[3] == auxillaryStrand_2[5]) && (auxillaryStrand_2[6] == auxillaryStrand_2[7]) && (auxillaryStrand_2[6] == auxillaryStrand_2[8])) && (auxillaryStrand_2[12] == 'A' && auxillaryStrand_2[13] == 'T' && auxillaryStrand_2[14] == 'G')
        && ((auxillaryStrand_2[auxillaryStrand_2.Length - 1] == stopCodon1[2] && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == stopCodon1[1] &&
        auxillaryStrand_2[auxillaryStrand_2.Length - 3] == stopCodon1[0]) || (auxillaryStrand_2[auxillaryStrand_2.Length - 1] == stopCodon2[2] && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == stopCodon2[1] &&
        auxillaryStrand_2[auxillaryStrand_2.Length - 3] == stopCodon2[0]) || (auxillaryStrand_2[auxillaryStrand_2.Length - 1] == stopCodon3[2] && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == stopCodon3[1] &&
        auxillaryStrand_2[auxillaryStrand_2.Length - 3] == stopCodon3[0]))))
        {
            if (controlFlag == false)
            {
                Console.Write("DNA Strand : ");
                Space();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                Console.WriteLine("\nGender error. Number of genes error.");
            }
        }
        if ((auxillaryStrand_2[0] == 'A' && auxillaryStrand_2[1] == 'T' && auxillaryStrand_2[2] == 'G' && auxillaryStrand_2[9] == 'T') && ((auxillaryStrand_2[10] == stopCodon1[1])
        || (auxillaryStrand_2[10] == stopCodon2[1]) || (auxillaryStrand_2[10] == stopCodon3[1])) && ((auxillaryStrand_2[11] == stopCodon1[2]) || (auxillaryStrand_2[11] == stopCodon2[2]) || (auxillaryStrand_2[11] == stopCodon3[2])) &&
        ((auxillaryStrand_2[3] == auxillaryStrand_2[4]) && (auxillaryStrand_2[3] == auxillaryStrand_2[5]) && (auxillaryStrand_2[6] == auxillaryStrand_2[7]) && (auxillaryStrand_2[6] == auxillaryStrand_2[8]))
        && ((auxillaryStrand_2[auxillaryStrand_2.Length - 1] == stopCodon1[2] && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == stopCodon1[1] &&
        auxillaryStrand_2[auxillaryStrand_2.Length - 3] == stopCodon1[0]) || (auxillaryStrand_2[auxillaryStrand_2.Length - 1] == stopCodon2[2] && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == stopCodon2[1] &&
        auxillaryStrand_2[auxillaryStrand_2.Length - 3] == stopCodon2[0]) || (auxillaryStrand_2[auxillaryStrand_2.Length - 1] == stopCodon3[2] && auxillaryStrand_2[auxillaryStrand_2.Length - 2] == stopCodon3[1] &&
        auxillaryStrand_2[auxillaryStrand_2.Length - 3] == stopCodon3[0])))
        {
            if (auxillaryStrand_2.Length > 14)
            {
                if ((auxillaryStrand_2[12] == 'A' && auxillaryStrand_2[13] == 'T' && auxillaryStrand_2[14] == 'G'))
                {
                    if (auxillaryStrand_2.Length > 18)
                    {
                        if (!((stopCodon1[0] == auxillaryStrand_2[15] && stopCodon1[1] == auxillaryStrand_2[16] && stopCodon1[2] == auxillaryStrand_2[17])
                        || (stopCodon2[0] == auxillaryStrand_2[15] && stopCodon2[1] == auxillaryStrand_2[16] && stopCodon2[2] == auxillaryStrand_2[17])
                        || (stopCodon3[0] == auxillaryStrand_2[15] && stopCodon3[1] == auxillaryStrand_2[16] && stopCodon3[2] == auxillaryStrand_2[17])))
                        {
                            Console.Write("DNA Strand : ");
                            Space();
                            Thread.Sleep(1000);
                            Console.WriteLine("\n");
                            Console.WriteLine("\nBLOB is OK.");
                        }
                    }
                    else
                    {
                        Console.Write("DNA Strand : ");
                        Space();
                        Thread.Sleep(1000);
                        Console.WriteLine("\n");
                        Console.WriteLine("\nNumber of codons error.");
                    }
                }
                else
                {
                    Console.Write("DNA Strand : ");
                    Space();
                    Thread.Sleep(1000);
                    Console.WriteLine("\n");
                    Console.WriteLine("\nNumber of genes error.");
                }
            }
            else
            {
                Console.Write("DNA Strand : ");
                Space();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                Console.WriteLine("\nNumber of genes error.");
            }
        }
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        bool controlFlag = false;

        for (int i = 0; i < 9; i = i + 3)
        {
            if ((auxillaryStrand_3[i] == stopCodon1[0] && auxillaryStrand_3[i + 1] == stopCodon1[1] && auxillaryStrand_3[i + 2] == stopCodon1[2]) ||
                (auxillaryStrand_3[i] == stopCodon2[0] && auxillaryStrand_3[i + 1] == stopCodon2[1] && auxillaryStrand_3[i + 2] == stopCodon2[2]) ||
                (auxillaryStrand_3[i] == stopCodon3[0] && auxillaryStrand_3[i + 1] == stopCodon3[1] && auxillaryStrand_3[i + 2] == stopCodon3[2]))
            {
                Console.Write("DNA Strand : ");
                Space();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                Console.WriteLine("\nGender error.");
                controlFlag = true;
            }
        }
        if (((auxillaryStrand_3[3] != auxillaryStrand_3[4]) || (auxillaryStrand_3[3] != auxillaryStrand_3[5]) || (auxillaryStrand_3[6] != auxillaryStrand_3[7]) || (auxillaryStrand_3[6] != auxillaryStrand_3[8])) &&
        (auxillaryStrand_3[0] == 'A' && auxillaryStrand_3[1] == 'T' && auxillaryStrand_3[2] == 'G' && auxillaryStrand_3[9] == 'T') && (((auxillaryStrand_3[10] == stopCodon1[1])
        && (auxillaryStrand_3[11] == stopCodon1[2])) || ((auxillaryStrand_3[10] == stopCodon2[1]) && (auxillaryStrand_3[11] == stopCodon2[2])) || ((auxillaryStrand_3[10] == stopCodon3[1]) && (auxillaryStrand_3[11] == stopCodon3[2])))
        && (auxillaryStrand_3[12] == 'A' && auxillaryStrand_3[13] == 'T' && auxillaryStrand_3[14] == 'G')
        && ((auxillaryStrand_3[auxillaryStrand_3.Length - 1] == stopCodon1[2] && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == stopCodon1[1] &&
        auxillaryStrand_3[auxillaryStrand_3.Length - 3] == stopCodon1[0]) || (auxillaryStrand_3[auxillaryStrand_3.Length - 1] == stopCodon2[2] && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == stopCodon2[1] &&
        auxillaryStrand_3[auxillaryStrand_3.Length - 3] == stopCodon2[0]) || (auxillaryStrand_3[auxillaryStrand_3.Length - 1] == stopCodon3[2] && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == stopCodon3[1] &&
        auxillaryStrand_3[auxillaryStrand_3.Length - 3] == stopCodon3[0])))
        {
            Console.Write("DNA Strand : ");
            Space();
            Thread.Sleep(1000);
            Console.WriteLine("\n");
            Console.WriteLine("\nGender error.");
        }
        else if ((auxillaryStrand_3[3] != auxillaryStrand_3[4]) || (auxillaryStrand_3[3] != auxillaryStrand_3[5]) || (auxillaryStrand_3[6] != auxillaryStrand_3[7]) || (auxillaryStrand_3[6] != auxillaryStrand_3[8]) &&
        !((auxillaryStrand_3[0] == 'A' && auxillaryStrand_3[1] == 'T' && auxillaryStrand_3[2] == 'G' && auxillaryStrand_3[9] == 'T') && ((auxillaryStrand_3[10] == stopCodon1[1])
        || (auxillaryStrand_3[10] == stopCodon2[1]) || (auxillaryStrand_3[10] == stopCodon3[1])) && ((auxillaryStrand_3[11] == stopCodon1[2]) || (auxillaryStrand_3[11] == stopCodon2[2]) || (auxillaryStrand_3[11] == stopCodon3[2])) &&
        ((auxillaryStrand_3[3] == auxillaryStrand_3[4]) && (auxillaryStrand_3[3] == auxillaryStrand_3[5]) && (auxillaryStrand_3[6] == auxillaryStrand_3[7]) && (auxillaryStrand_3[6] == auxillaryStrand_3[8])) && (auxillaryStrand_3[12] == 'A' && auxillaryStrand_3[13] == 'T' && auxillaryStrand_3[14] == 'G')
        && ((auxillaryStrand_3[auxillaryStrand_3.Length - 1] == stopCodon1[2] && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == stopCodon1[1] &&
        auxillaryStrand_3[auxillaryStrand_3.Length - 3] == stopCodon1[0]) || (auxillaryStrand_3[auxillaryStrand_3.Length - 1] == stopCodon2[2] && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == stopCodon2[1] &&
        auxillaryStrand_3[auxillaryStrand_3.Length - 3] == stopCodon2[0]) || (auxillaryStrand_3[auxillaryStrand_3.Length - 1] == stopCodon3[2] && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == stopCodon3[1] &&
        auxillaryStrand_3[auxillaryStrand_3.Length - 3] == stopCodon3[0]))))
        {
            if (controlFlag == false)
            {
                Console.Write("DNA Strand : ");
                Space();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                Console.WriteLine("\nGender error. Number of genes error.");
            }
        }
        if ((auxillaryStrand_3[0] == 'A' && auxillaryStrand_3[1] == 'T' && auxillaryStrand_3[2] == 'G' && auxillaryStrand_3[9] == 'T') && ((auxillaryStrand_3[10] == stopCodon1[1])
        || (auxillaryStrand_3[10] == stopCodon2[1]) || (auxillaryStrand_3[10] == stopCodon3[1])) && ((auxillaryStrand_3[11] == stopCodon1[2]) || (auxillaryStrand_3[11] == stopCodon2[2]) || (auxillaryStrand_3[11] == stopCodon3[2])) &&
        ((auxillaryStrand_3[3] == auxillaryStrand_3[4]) && (auxillaryStrand_3[3] == auxillaryStrand_3[5]) && (auxillaryStrand_3[6] == auxillaryStrand_3[7]) && (auxillaryStrand_3[6] == auxillaryStrand_3[8]))
        && ((auxillaryStrand_3[auxillaryStrand_3.Length - 1] == stopCodon1[2] && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == stopCodon1[1] &&
        auxillaryStrand_3[auxillaryStrand_3.Length - 3] == stopCodon1[0]) || (auxillaryStrand_3[auxillaryStrand_3.Length - 1] == stopCodon2[2] && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == stopCodon2[1] &&
        auxillaryStrand_3[auxillaryStrand_3.Length - 3] == stopCodon2[0]) || (auxillaryStrand_3[auxillaryStrand_3.Length - 1] == stopCodon3[2] && auxillaryStrand_3[auxillaryStrand_3.Length - 2] == stopCodon3[1] &&
        auxillaryStrand_3[auxillaryStrand_3.Length - 3] == stopCodon3[0])))
        {
            if (auxillaryStrand_3.Length > 14)
            {
                if ((auxillaryStrand_3[12] == 'A' && auxillaryStrand_3[13] == 'T' && auxillaryStrand_3[14] == 'G'))
                {
                    if (auxillaryStrand_3.Length > 18)
                    {
                        if (!((auxillaryStrand_3[0] == auxillaryStrand_3[15] && stopCodon1[1] == auxillaryStrand_3[16] && stopCodon1[2] == auxillaryStrand_3[17])
                        || (auxillaryStrand_3[0] == auxillaryStrand_3[15] && stopCodon2[1] == auxillaryStrand_3[16] && stopCodon2[2] == auxillaryStrand_3[17])
                        || (auxillaryStrand_3[0] == auxillaryStrand_3[15] && stopCodon3[1] == auxillaryStrand_3[16] && stopCodon3[2] == auxillaryStrand_3[17])))
                        {
                            Console.Write("DNA Strand : ");
                            Space();
                            Thread.Sleep(1000);
                            Console.WriteLine("\n");
                            Console.WriteLine("\nBLOB is OK.");
                        }
                    }
                    else
                    {
                        Console.Write("DNA Strand : ");
                        Space();
                        Thread.Sleep(1000);
                        Console.WriteLine("\n");
                        Console.WriteLine("\nNumber of codons error.");
                    }
                }
                else
                {
                    Console.Write("DNA Strand : ");
                    Space();
                    Thread.Sleep(1000);
                    Console.WriteLine("\n");
                    Console.WriteLine("\nNumber of genes error.");
                }
            }
            else
            {
                Console.Write("DNA Strand : ");
                Space();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                Console.WriteLine("\nNumber of genes error.");
            }
        }
    }
}

// Operation 6
void complement()
{
    if (mainStrand.Length != 0)
    {
        Console.Write("DNA Strand : ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nComplement : ");
        char[] complement = new char[mainStrand.Length];
        for (int i = 0; i < mainStrand.Length; i++)
        {
            if (mainStrand[i] == 'A')
                complement[i] = 'T';
            if (mainStrand[i] == 'T')
                complement[i] = 'A';
            if (mainStrand[i] == 'G')
                complement[i] = 'C';
            if (mainStrand[i] == 'C')
                complement[i] = 'G';
        }
        mainStrand = complement;
        for (int i = 0; i < mainStrand.Length; i++)
        {
            Console.Write(mainStrand[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
    }
    if (auxillaryStrand_2.Length != 0)
    {
        Console.Write("DNA Strand : ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nComplement : ");
        char[] complement = new char[auxillaryStrand_2.Length];
        for (int i = 0; i < auxillaryStrand_2.Length; i++)
        {
            if (auxillaryStrand_2[i] == 'A')
                complement[i] = 'T';
            if (auxillaryStrand_2[i] == 'T')
                complement[i] = 'A';
            if (auxillaryStrand_2[i] == 'G')
                complement[i] = 'C';
            if (auxillaryStrand_2[i] == 'C')
                complement[i] = 'G';
        }
        auxillaryStrand_2 = complement;
        for (int i = 0; i < auxillaryStrand_2.Length; i++)
        {
            Console.Write(auxillaryStrand_2[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
    }
    if (auxillaryStrand_3.Length != 0)
    {
        Console.Write("DNA Strand : ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nComplement : ");
        char[] complement = new char[auxillaryStrand_3.Length];
        for (int i = 0; i < auxillaryStrand_3.Length; i++)
        {
            if (auxillaryStrand_3[i] == 'A')
                complement[i] = 'T';
            if (auxillaryStrand_3[i] == 'T')
                complement[i] = 'A';
            if (auxillaryStrand_3[i] == 'G')
                complement[i] = 'C';
            if (auxillaryStrand_3[i] == 'C')
                complement[i] = 'G';
        }
        auxillaryStrand_3 = complement;
        for (int i = 0; i < auxillaryStrand_3.Length; i++)
        {
            Console.Write(auxillaryStrand_3[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
    }
}

// Operation 7
void aminoacids()
{
    if (mainStrand.Length != 0)
    {
        string[] op7 = new string[mainStrand.Length / 3];
        string concencrate = "";
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\n");
        Console.Write("Amino Acids : ");
        for (int i = 0; i < mainStrand.Length; i += 3)
        {
            concencrate += mainStrand[i];
            concencrate += mainStrand[i + 1];
            concencrate += mainStrand[i + 2];
            op7[i / 3] = concencrate;
            concencrate = "";
        }
        for (int i = 0; i < op7.Length; i++)
        {
            if (op7[i] == "GCT" || op7[i] == "GCC" || op7[i] == "GCA" || op7[i] == "GCG")
            {
                Console.Write("Ala" + " ");
            }
            if (op7[i] == "CGT" || op7[i] == "CGC" || op7[i] == "CGA" || op7[i] == "CGG" || op7[i] == "AGA" || op7[i] == "AGG")
            {
                Console.Write("Arg" + " ");
            }
            if (op7[i] == "AAT" || op7[i] == "AAC")
            {
                Console.Write("Asn" + " ");
            }
            if (op7[i] == "GAT" || op7[i] == "GAC")
            {
                Console.Write("Asp" + " ");
            }
            if (op7[i] == "TGT" || op7[i] == "TGC")
            {
                Console.Write("Cys" + " ");
            }
            if (op7[i] == "CAA" || op7[i] == "CAG")
            {
                Console.Write("Gln" + " ");
            }
            if (op7[i] == "GAA" || op7[i] == "GAG")
            {
                Console.Write("Glu" + " ");
            }
            if (op7[i] == "GGT" || op7[i] == "GGC" || op7[i] == "GGA" || op7[i] == "GGG")
            {
                Console.Write("Gly" + " ");
            }
            if (op7[i] == "CAT" || op7[i] == "CAC")
            {
                Console.Write("His" + " ");
            }
            if (op7[i] == "ATT" || op7[i] == "ATC" || op7[i] == "ATA")
            {
                Console.Write("Ile" + " ");
            }
            if (op7[i] == "CTT" || op7[i] == "CTC" || op7[i] == "CTA" || op7[i] == "CTG" || op7[i] == "TTA" || op7[i] == "TTG")
            {
                Console.Write("Leu" + " ");
            }
            if (op7[i] == "AAA" || op7[i] == "AAG")
            {
                Console.Write("Lys" + " ");
            }
            if (op7[i] == "ATG")
            {
                Console.Write("Met" + " ");
            }
            if (op7[i] == "TTT" || op7[i] == "TTC")
            {
                Console.Write("Phe" + " ");
            }
            if (op7[i] == "CCT" || op7[i] == "CCC" || op7[i] == "CCA" || op7[i] == "CCG")
            {
                Console.Write("Gly" + " ");
            }
            if (op7[i] == "TCT" || op7[i] == "TCA" || op7[i] == "TCC" || op7[i] == "TCG" || op7[i] == "AGT" || op7[i] == "AGC")
            {
                Console.Write("Ser" + " ");
            }
            if (op7[i] == "ACT" || op7[i] == "ACA" || op7[i] == "ACG" || op7[i] == "ACC")
            {
                Console.Write("Thr" + " ");
            }
            if (op7[i] == "TGG")
            {
                Console.Write("Trp" + " ");
            }
            if (op7[i] == "TAT" || op7[i] == "TAC")
            {
                Console.Write("Tyr" + " ");
            }
            if (op7[i] == "GTT" || op7[i] == "GTC" || op7[i] == "GTA" || op7[i] == "GTG")
            {
                Console.Write("Val" + " ");
            }
            if (op7[i] == "TAA" || op7[i] == "TGA" || op7[i] == "TAG")
            {
                Console.Write("END" + " ");
            }
        }
    }
    if (auxillaryStrand_2.Length != 0)
    {
        string[] op7 = new string[auxillaryStrand_2.Length / 3];
        string concencrate = "";
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("Amino Acids : ");
        for (int i = 0; i < auxillaryStrand_2.Length; i += 3)
        {
            concencrate += auxillaryStrand_2[i];
            concencrate += auxillaryStrand_2[i + 1];
            concencrate += auxillaryStrand_2[i + 2];
            op7[i / 3] = concencrate;
            concencrate = "";
        }
        for (int i = 0; i < op7.Length; i++)
        {
            if (op7[i] == "GCT" || op7[i] == "GCC" || op7[i] == "GCA" || op7[i] == "GCG")
            {
                Console.Write("Ala" + " ");
            }
            if (op7[i] == "CGT" || op7[i] == "CGC" || op7[i] == "CGA" || op7[i] == "CGG" || op7[i] == "AGA" || op7[i] == "AGG")
            {
                Console.Write("Arg" + " ");
            }
            if (op7[i] == "AAT" || op7[i] == "AAC")
            {
                Console.Write("Asn" + " ");
            }
            if (op7[i] == "GAT" || op7[i] == "GAC")
            {
                Console.Write("Asp" + " ");
            }
            if (op7[i] == "TGT" || op7[i] == "TGC")
            {
                Console.Write("Cys" + " ");
            }
            if (op7[i] == "CAA" || op7[i] == "CAG")
            {
                Console.Write("Gln" + " ");
            }
            if (op7[i] == "GAA" || op7[i] == "GAG")
            {
                Console.Write("Glu" + " ");
            }
            if (op7[i] == "GGT" || op7[i] == "GGC" || op7[i] == "GGA" || op7[i] == "GGG")
            {
                Console.Write("Gly" + " ");
            }
            if (op7[i] == "CAT" || op7[i] == "CAC")
            {
                Console.Write("His" + " ");
            }
            if (op7[i] == "ATT" || op7[i] == "ATC" || op7[i] == "ATA")
            {
                Console.Write("Ile" + " ");
            }
            if (op7[i] == "CTT" || op7[i] == "CTC" || op7[i] == "CTA" || op7[i] == "CTG" || op7[i] == "TTA" || op7[i] == "TTG")
            {
                Console.Write("Leu" + " ");
            }
            if (op7[i] == "AAA" || op7[i] == "AAG")
            {
                Console.Write("Lys" + " ");
            }
            if (op7[i] == "ATG")
            {
                Console.Write("Met" + " ");
            }
            if (op7[i] == "TTT" || op7[i] == "TTC")
            {
                Console.Write("Phe" + " ");
            }
            if (op7[i] == "CCT" || op7[i] == "CCC" || op7[i] == "CCA" || op7[i] == "CCG")
            {
                Console.Write("Gly" + " ");
            }
            if (op7[i] == "TCT" || op7[i] == "TCA" || op7[i] == "TCC" || op7[i] == "TCG" || op7[i] == "AGT" || op7[i] == "AGC")
            {
                Console.Write("Ser" + " ");
            }
            if (op7[i] == "ACT" || op7[i] == "ACA" || op7[i] == "ACG" || op7[i] == "ACC")
            {
                Console.Write("Thr" + " ");
            }
            if (op7[i] == "TGG")
            {
                Console.Write("Trp" + " ");
            }
            if (op7[i] == "TAT" || op7[i] == "TAC")
            {
                Console.Write("Tyr" + " ");
            }
            if (op7[i] == "GTT" || op7[i] == "GTC" || op7[i] == "GTA" || op7[i] == "GTG")
            {
                Console.Write("Val" + " ");
            }
            if (op7[i] == "TAA" || op7[i] == "TGA" || op7[i] == "TAG")
            {
                Console.Write("END" + " ");
            }
        }
    }
    if (auxillaryStrand_3.Length != 0)
    {
        string[] op7 = new string[auxillaryStrand_3.Length / 3];
        string concencrate = "";
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("Amino Acids : ");
        for (int i = 0; i < auxillaryStrand_3.Length; i += 3)
        {
            concencrate += auxillaryStrand_3[i];
            concencrate += auxillaryStrand_3[i + 1];
            concencrate += auxillaryStrand_3[i + 2];
            op7[i / 3] = concencrate;
            concencrate = "";
        }
        for (int i = 0; i < op7.Length; i++)
        {
            if (op7[i] == "GCT" || op7[i] == "GCC" || op7[i] == "GCA" || op7[i] == "GCG")
            {
                Console.Write("Ala" + " ");
            }
            if (op7[i] == "CGT" || op7[i] == "CGC" || op7[i] == "CGA" || op7[i] == "CGG" || op7[i] == "AGA" || op7[i] == "AGG")
            {
                Console.Write("Arg" + " ");
            }
            if (op7[i] == "AAT" || op7[i] == "AAC")
            {
                Console.Write("Asn" + " ");
            }
            if (op7[i] == "GAT" || op7[i] == "GAC")
            {
                Console.Write("Asp" + " ");
            }
            if (op7[i] == "TGT" || op7[i] == "TGC")
            {
                Console.Write("Cys" + " ");
            }
            if (op7[i] == "CAA" || op7[i] == "CAG")
            {
                Console.Write("Gln" + " ");
            }
            if (op7[i] == "GAA" || op7[i] == "GAG")
            {
                Console.Write("Glu" + " ");
            }
            if (op7[i] == "GGT" || op7[i] == "GGC" || op7[i] == "GGA" || op7[i] == "GGG")
            {
                Console.Write("Gly" + " ");
            }
            if (op7[i] == "CAT" || op7[i] == "CAC")
            {
                Console.Write("His" + " ");
            }
            if (op7[i] == "ATT" || op7[i] == "ATC" || op7[i] == "ATA")
            {
                Console.Write("Ile" + " ");
            }
            if (op7[i] == "CTT" || op7[i] == "CTC" || op7[i] == "CTA" || op7[i] == "CTG" || op7[i] == "TTA" || op7[i] == "TTG")
            {
                Console.Write("Leu" + " ");
            }
            if (op7[i] == "AAA" || op7[i] == "AAG")
            {
                Console.Write("Lys" + " ");
            }
            if (op7[i] == "ATG")
            {
                Console.Write("Met" + " ");
            }
            if (op7[i] == "TTT" || op7[i] == "TTC")
            {
                Console.Write("Phe" + " ");
            }
            if (op7[i] == "CCT" || op7[i] == "CCC" || op7[i] == "CCA" || op7[i] == "CCG")
            {
                Console.Write("Gly" + " ");
            }
            if (op7[i] == "TCT" || op7[i] == "TCA" || op7[i] == "TCC" || op7[i] == "TCG" || op7[i] == "AGT" || op7[i] == "AGC")
            {
                Console.Write("Ser" + " ");
            }
            if (op7[i] == "ACT" || op7[i] == "ACA" || op7[i] == "ACG" || op7[i] == "ACC")
            {
                Console.Write("Thr" + " ");
            }
            if (op7[i] == "TGG")
            {
                Console.Write("Trp" + " ");
            }
            if (op7[i] == "TAT" || op7[i] == "TAC")
            {
                Console.Write("Tyr" + " ");
            }
            if (op7[i] == "GTT" || op7[i] == "GTC" || op7[i] == "GTA" || op7[i] == "GTG")
            {
                Console.Write("Val" + " ");
            }
            if (op7[i] == "TAA" || op7[i] == "TGA" || op7[i] == "TAG")
            {
                Console.Write("END" + " ");
            }
        }
    }
}

// Operation 8
void deleteCodons()
{
    if (mainStrand.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand (Stage 1): ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nNumber of the codons to delete: ");
        int deletecodon = Convert.ToInt32(Console.ReadLine());
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nDelete " + deletecodon + " codons, starting from " + start_from);
        Console.Write("\nDna strand (stage 2) : ");
        // Saving the DNA Strand after the change...
        char[] deleteStrand = new char[mainStrand.Length - deletecodon * 3];

        // Perfom delete operation
        for (int i = 0; i < (3 * start_from - 3); i++)
        {
            deleteStrand[i] = mainStrand[i];
        }
        for (int i = (3 * start_from - 3 + deletecodon * 3); i < mainStrand.Length; i++)
        {
            deleteStrand[i - deletecodon * 3] = mainStrand[i];
        }
        mainStrand = deleteStrand;

        for (int i = 0; i < mainStrand.Length; i++)
        {
            Console.Write(mainStrand[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("\nDNA Strand (Stage 1): ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nNumber of the codons to delete: ");
        int deletecodon = Convert.ToInt32(Console.ReadLine());
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nDelete " + deletecodon + " codons, starting from " + start_from);
        Console.Write("\nDna strand (stage 2) : ");
        // Saving the DNA Strand after the change...
        char[] deleteAuxillaryStrand_2 = new char[auxillaryStrand_2.Length - deletecodon * 3];

        // Perfom delete operation
        for (int i = 0; i < (3 * start_from - 3); i++)
        {
            deleteAuxillaryStrand_2[i] = auxillaryStrand_2[i];
        }
        for (int i = (3 * start_from - 3 + deletecodon * 3); i < auxillaryStrand_2.Length; i++)
        {
            deleteAuxillaryStrand_2[i - deletecodon * 3] = auxillaryStrand_2[i];
        }
        auxillaryStrand_2 = deleteAuxillaryStrand_2;

        for (int i = 0; i < auxillaryStrand_2.Length; i++)
        {
            Console.Write(auxillaryStrand_2[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("\nDNA Strand (Stage 1): ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nNumber of the codons to delete: ");
        int deletecodon = Convert.ToInt32(Console.ReadLine());
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nDelete " + deletecodon + " codons, starting from " + start_from);
        Console.Write("\nDna strand (stage 2) : ");
        // Saving the DNA Strand after the change...
        char[] deleteAuxillaryStrand_3 = new char[auxillaryStrand_3.Length - deletecodon * 3];

        // Perfom delete operation
        for (int i = 0; i < (3 * start_from - 3); i++)
        {
            deleteAuxillaryStrand_3[i] = auxillaryStrand_3[i];
        }
        for (int i = (3 * start_from - 3 + deletecodon * 3); i < auxillaryStrand_3.Length; i++)
        {
            deleteAuxillaryStrand_3[i - deletecodon * 3] = auxillaryStrand_3[i];
        }
        auxillaryStrand_3 = deleteAuxillaryStrand_3;

        for (int i = 0; i < auxillaryStrand_3.Length; i++)
        {
            Console.Write(auxillaryStrand_3[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
    }
    Console.Write("\n");
    Console.WriteLine("\nYour Codon sequence has been deleted successfully!");
}

// Operation 9
void insertCodons() // need fixing
{
    if (mainStrand.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand (Stage 1): ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nCodon sequence: ");
        string codonSequence = Console.ReadLine().ToUpper();
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        char[] insertStrand = new char[mainStrand.Length + codonSequence.Length * 3];
        char[] codonSequencearray = new char[codonSequence.Length];
        // Print array of DNA Strand after insertion
        Console.Write("\nDNA Strand (Stage 2): ");
        
        // Perform insert operation
        for (int i = 0; i < codonSequence.Length; i++)
        {
            codonSequencearray[i] = codonSequence[i];
        }
        for (int i = 0; i < (3 * start_from - 3); i++)
        {
            insertStrand[i] = mainStrand[i];
        }
        for (int i = (3 * start_from - 3); i < (3 * start_from - 3 + codonSequencearray.Length); i++)
        {
            insertStrand[i] = codonSequencearray[i - (3 * start_from - 3)];
        }
        for (int i = (3 * start_from - 3 + codonSequencearray.Length); i < (codonSequencearray.Length + mainStrand.Length); i++)
        {
            insertStrand[i] = mainStrand[i - (codonSequencearray.Length)];
        }
        mainStrand = insertStrand;
        for (int i = 0; i < mainStrand.Length; i++)
        {
            Console.Write(mainStrand[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand (Stage 1): ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nCodon sequence: ");
        string codonSequence = Console.ReadLine().ToUpper();
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        char[] insertAuxillaryStrand_2 = new char[auxillaryStrand_2.Length + codonSequence.Length * 3];
        char[] codonSequencearray = new char[codonSequence.Length];
        // Print array of DNA Strand after insertion
        Console.WriteLine("\nDNA Strand (Stage 2): ");

        // Perform insert operation
        for (int i = 0; i < codonSequence.Length; i++)
        {
            codonSequencearray[i] = codonSequence[i];
        }
        for (int i = 0; i < (3 * start_from - 3); i++)
        {
            insertAuxillaryStrand_2[i] = auxillaryStrand_2[i];
        }
        for (int i = (3 * start_from - 3); i < (3 * start_from - 3 + codonSequencearray.Length); i++)
        {
            insertAuxillaryStrand_2[i] = codonSequencearray[i - (3 * start_from - 3)];
        }
        for (int i = (3 * start_from - 3 + codonSequencearray.Length); i < (codonSequencearray.Length + auxillaryStrand_2.Length); i++)
        {
            insertAuxillaryStrand_2[i] = auxillaryStrand_2[i - (codonSequencearray.Length)];
        }
        auxillaryStrand_2 = insertAuxillaryStrand_2;
        for (int i = 0; i < auxillaryStrand_2.Length; i++)
        {
            Console.Write(auxillaryStrand_2[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand (Stage 1): ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nCodon sequence: ");
        string codonSequence = Console.ReadLine().ToUpper();
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        char[] insertAuxillaryStrand_3 = new char[auxillaryStrand_3.Length + codonSequence.Length * 3];
        char[] codonSequencearray = new char[codonSequence.Length];
        // Print array of DNA Strand after insertion
        Console.WriteLine("\nDNA Strand (Stage 2): ");

        // Perform insert operation
        for (int i = 0; i < codonSequence.Length; i++)
        {
            codonSequencearray[i] = codonSequence[i];
        }
        for (int i = 0; i < (3 * start_from - 3); i++)
        {
            insertAuxillaryStrand_3[i] = auxillaryStrand_3[i];
        }
        for (int i = (3 * start_from - 3); i < (3 * start_from - 3 + codonSequencearray.Length); i++)
        {
            insertAuxillaryStrand_3[i] = codonSequencearray[i - (3 * start_from - 3)];
        }
        for (int i = (3 * start_from - 3 + codonSequencearray.Length); i < (codonSequencearray.Length + auxillaryStrand_3.Length); i++)
        {
            insertAuxillaryStrand_3[i] = auxillaryStrand_3[i - (codonSequencearray.Length)];
        }
        auxillaryStrand_3 = insertAuxillaryStrand_3;
        for (int i = 0; i < auxillaryStrand_3.Length; i++)
        {
            Console.Write(auxillaryStrand_3[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
    }
    Console.Write("\n");
    Console.WriteLine("\nYour Codon sequence has been added successfully!");
}

// Operation 10 
void findCondons()
{
    if (mainStrand.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand: ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nCodon sequence: ");
        string codonSequence = Console.ReadLine().ToUpper();
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        char[] codonSequencearray = new char[codonSequence.Length];
        int result = -1;

        // Perform finding operation
        for (int i = 0; i < codonSequence.Length; i++)
        {
            codonSequencearray[i] = codonSequence[i];
        }

        bool flag = false;
        int checker = 0;
        for (int i = (3 * start_from - 3); i < mainStrand.Length - codonSequence.Length; i++)
        {
            for (int j = 0; j < codonSequence.Length; j++)
            {
                if (codonSequencearray[j] == mainStrand[i])
                {
                    checker++;
                }
                if (checker == codonSequencearray.Length)
                {
                    result = (i - codonSequence.Length + 4) / 3;
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag == true)
            {
                break;
            }
            checker = 0;
            i -= codonSequence.Length;

        }
        Console.WriteLine("Result : " + result);
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand: ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nCodon sequence: ");
        string codonSequence = Console.ReadLine().ToUpper();
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        char[] codonSequencearray = new char[codonSequence.Length];
        int result = -1;

        // Perform finding operation
        for (int i = 0; i < codonSequence.Length; i++)
        {
            codonSequencearray[i] = codonSequence[i];
        }

        bool flag = false;
        int checker = 0;
        for (int i = (3 * start_from - 3); i < auxillaryStrand_2.Length - codonSequence.Length; i++)
        {
            for (int j = 0; j < codonSequence.Length; j++)
            {
                if (codonSequencearray[j] == auxillaryStrand_2[i])
                {
                    checker++;
                }
                if (checker == codonSequencearray.Length)
                {
                    result = (i - codonSequence.Length + 4) / 3;
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag == true)
            {
                break;
            }
            checker = 0;
            i -= codonSequence.Length;

        }
        Console.WriteLine("Result : " + result);
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand: ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nCodon sequence: ");
        string codonSequence = Console.ReadLine().ToUpper();
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        char[] codonSequencearray = new char[codonSequence.Length];
        int result = -1;

        // Perform finding operation
        for (int i = 0; i < codonSequence.Length; i++)
        {
            codonSequencearray[i] = codonSequence[i];
        }

        bool flag = false;
        int checker = 0;
        for (int i = (3 * start_from - 3); i < auxillaryStrand_3.Length - codonSequence.Length; i++)
        {
            for (int j = 0; j < codonSequence.Length; j++)
            {
                if (codonSequencearray[j] == auxillaryStrand_3[i])
                {
                    checker++;
                }
                if (checker == codonSequencearray.Length)
                {
                    result = (i - codonSequence.Length + 4) / 3;
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag == true)
            {
                break;
            }
            checker = 0;
            i -= codonSequence.Length;
        }
        Console.WriteLine("Result : " + result);
    }
}

// Operation 11
void reverseCodons()
{
    if (mainStrand.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand (Stage 1): ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nNumber of the codons to reverse: ");
        int reversecodon = Convert.ToInt32(Console.ReadLine());
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nReverse " + reversecodon + " codons, starting from " + start_from);
        Console.Write("\nDna strand (stage 2) : ");
        // Saving the DNA Strand after the change...
        char[] reverseStrand = new char[mainStrand.Length];

        // Perfom delete operation
        for (int i = 0; i < (3 * start_from - 3); i++) // Reverse strand is equal to main strand until we hit the reverse point.
        {
            reverseStrand[i] = mainStrand[i];
        }
        for (int i = (3 * start_from - 3); i < (3 * start_from - 3 + reversecodon * 3); i += 3) // Doing the reverse in the given interval.
        {
            reverseStrand[i] = mainStrand[3 * (reversecodon - 1) + (6 * (start_from - 1)) - i];
            reverseStrand[i + 1] = mainStrand[3 * (reversecodon - 1) + (6 * (start_from - 1)) - i + 1];
            reverseStrand[i + 2] = mainStrand[3 * (reversecodon - 1) + (6 * (start_from - 1)) - i + 2];
        }
        for (int i = (3 * start_from - 3 + reversecodon * 3); i < mainStrand.Length; i++) // Reverse strand is equal to main strand until exit the reverse point.
        {
            reverseStrand[i] = mainStrand[i];
        }
        mainStrand = reverseStrand; // Assigning the reverse strand value to main strand.
        for (int i = 0; i < mainStrand.Length; i++)
        {
            Console.Write(mainStrand[i]);
            if (i % 3 == 2) // Adds space per 3 character.
                Console.Write(" ");
        }
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand (Stage 1): ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nNumber of the codons to reverse: ");
        int reversecodon = Convert.ToInt32(Console.ReadLine());
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nReverse " + reversecodon + " codons, starting from " + start_from);
        Console.Write("\nDna strand (stage 2) : ");
        // Saving the DNA Strand after the change...
        char[] reverseAuxillaryStrand_2 = new char[auxillaryStrand_2.Length];

        // Perfom delete operation
        for (int i = 0; i < (3 * start_from - 3); i++) // Reverse strand is equal to main strand until we hit the reverse point.
        {
            reverseAuxillaryStrand_2[i] = auxillaryStrand_2[i];
        }
        for (int i = (3 * start_from - 3); i < (3 * start_from - 3 + reversecodon * 3); i += 3) // Doing the reverse in the given interval.
        {
            reverseAuxillaryStrand_2[i] = auxillaryStrand_2[3 * (reversecodon - 1) + (6 * (start_from - 1)) - i];
            reverseAuxillaryStrand_2[i + 1] = auxillaryStrand_2[3 * (reversecodon - 1) + (6 * (start_from - 1)) - i + 1];
            reverseAuxillaryStrand_2[i + 2] = auxillaryStrand_2[3 * (reversecodon - 1) + (6 * (start_from - 1)) - i + 2];
        }
        for (int i = (3 * start_from - 3 + reversecodon * 3); i < auxillaryStrand_2.Length; i++) // Reverse strand is equal to main strand until exit the reverse point.
        {
            reverseAuxillaryStrand_2[i] = auxillaryStrand_2[i];
        }
        auxillaryStrand_2 = reverseAuxillaryStrand_2; // Assigning the reverse strand value to main strand.
        for (int i = 0; i < auxillaryStrand_2.Length; i++)
        {
            Console.Write(auxillaryStrand_2[i]);
            if (i % 3 == 2) // Adds space per 3 character.
                Console.Write(" ");
        }
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        // Print array of DNA Strand
        Console.Write("DNA Strand (Stage 1): ");
        Space(); // printing on console with space
        //Array.ForEach(mainStrand, Console.Write); // printing on console without space
        Console.Write("\n");
        Console.Write("\nNumber of the codons to reverse: ");
        int reversecodon = Convert.ToInt32(Console.ReadLine());
        Console.Write("Starting from: ");
        int start_from = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nReverse " + reversecodon + " codons, starting from " + start_from);
        Console.Write("\nDna strand (stage 2) : ");
        // Saving the DNA Strand after the change...
        char[] reverseAuxillaryStrand_3 = new char[auxillaryStrand_3.Length];

        // Perfom delete operation
        for (int i = 0; i < (3 * start_from - 3); i++) // Reverse strand is equal to main strand until we hit the reverse point.
        {
            reverseAuxillaryStrand_3[i] = auxillaryStrand_3[i];
        }
        for (int i = (3 * start_from - 3); i < (3 * start_from - 3 + reversecodon * 3); i += 3) // Doing the reverse in the given interval.
        {
            reverseAuxillaryStrand_3[i] = auxillaryStrand_3[3 * (reversecodon - 1) + (6 * (start_from - 1)) - i];
            reverseAuxillaryStrand_3[i + 1] = auxillaryStrand_3[3 * (reversecodon - 1) + (6 * (start_from - 1)) - i + 1];
            reverseAuxillaryStrand_3[i + 2] = auxillaryStrand_3[3 * (reversecodon - 1) + (6 * (start_from - 1)) - i + 2];
        }
        for (int i = (3 * start_from - 3 + reversecodon * 3); i < auxillaryStrand_3.Length; i++) // Reverse strand is equal to main strand until exit the reverse point.
        {
            reverseAuxillaryStrand_3[i] = auxillaryStrand_3[i];
        }
        auxillaryStrand_3 = reverseAuxillaryStrand_3; // Assigning the reverse strand value to main strand.
        for (int i = 0; i < auxillaryStrand_3.Length; i++)
        {
            Console.Write(auxillaryStrand_3[i]);
            if (i % 3 == 2) // Adds space per 3 character.
                Console.Write(" ");
        }
    }
    Console.Write("\n");
    Console.WriteLine("\nYour Codon sequence has been reversed successfully!");
}

// Operation 12
void geneNumber()
{
    if (mainStrand.Length != 0)
    {
        string[] op12 = new string[mainStrand.Length / 3];
        string concencrate = "";
        int numberofgenes = 0;
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\nNumber of genes : ");
        for (int i = 0; i < mainStrand.Length; i += 3)
        {
            concencrate += mainStrand[i];
            concencrate += mainStrand[i + 1];
            concencrate += mainStrand[i + 2];
            op12[i / 3] = concencrate;
            concencrate = "";
        }
        int k = 0;
        for (int x = 0; x < op12.Length; x++)
        {
            for (int i = k  ; i < (op12.Length); i++)
            {
                bool flagop12 = false;
                if (op12[i] == "ATG")
                {
                    for (int j = i; j < op12.Length; j++)
                    {
                        if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                        {
                            numberofgenes++;
                            k = j;
                            flagop12 = true;
                            break;
                        }
                    }
                }
                if (flagop12 == true)
                    break;
            }
        }
        Console.Write(numberofgenes);
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        string[] op12 = new string[auxillaryStrand_2.Length / 3];
        string concencrate = "";
        int numberofgenes = 0;
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\nNumber of genes  : ");
        for (int i = 0; i < mainStrand.Length; i += 3)
        {
            concencrate += auxillaryStrand_2[i];
            concencrate += auxillaryStrand_2[i + 1];
            concencrate += auxillaryStrand_2[i + 2];
            op12[i / 3] = concencrate;
            concencrate = "";
        }
        int k = 0;
        for (int x = 0; x < op12.Length; x++)
        {
            for (int i = k; i < (op12.Length); i++)
            {
                bool flagop12 = false;
                if (op12[i] == "ATG")
                {

                    for (int j = i; j < op12.Length; j++)
                    {
                        if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                        {
                            numberofgenes++;
                            k = j;
                            flagop12 = true;
                            break;
                        }
                    }
                }
                if (flagop12 == true)
                    break;
            }
        }
        Console.Write(numberofgenes);
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        string[] op12 = new string[auxillaryStrand_3.Length / 3];
        string concencrate = "";
        int numberofgenes = 0;
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\nNumber of genes  : ");
        for (int i = 0; i < auxillaryStrand_3.Length; i += 3)
        {
            concencrate += auxillaryStrand_3[i];
            concencrate += auxillaryStrand_3[i + 1];
            concencrate += auxillaryStrand_3[i + 2];
            op12[i / 3] = concencrate;
            concencrate = "";
        }
        int k = 0;
        for (int x = 0; x < op12.Length; x++)
        {
            for (int i = k; i < (op12.Length); i++)
            {
                bool flagop12 = false;
                if (op12[i] == "ATG")
                {
                    for (int j = i; j < op12.Length; j++)
                    {
                        if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                        {
                            numberofgenes++;
                            k = j;
                            flagop12 = true;
                            break;
                        }
                    }
                }
                if (flagop12 == true)
                    break;
            }
        }
        Console.Write(numberofgenes);
    }
}

// Operation 13
void shortestGene()
{
    if (mainStrand.Length != 0)
    {
        string[] op12 = new string[mainStrand.Length / 3];
        string concencrate = "";
        int numberofgenes = 0;
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\nShortest gene                : ");
        for (int i = 0; i < mainStrand.Length; i += 3)
        {
            concencrate += mainStrand[i];
            concencrate += mainStrand[i + 1];
            concencrate += mainStrand[i + 2];
            op12[i / 3] = concencrate;
            concencrate = "";
        }
        int k = 0;
        int lengthofgene = 0;
        int shortestgene = 99;
        int intervalbelow = 0;
        int intervalabove = 0;
        for (int x = 0; x < op12.Length; x++)
        {
            for (int i = k; i < (op12.Length); i++)
            {
                bool flagop12 = false;
                if (op12[i] == "ATG")
                {

                    for (int j = i; j < op12.Length; j++)
                    {
                        if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                        {
                            numberofgenes++;
                            k = j;
                            flagop12 = true;
                            lengthofgene = j - i + 1;
                            if (lengthofgene < shortestgene)
                            {
                                shortestgene = lengthofgene;
                                intervalbelow = i;
                                intervalabove = j;
                            }
                            break;
                        }
                    }
                }
                if (flagop12 == true)
                    break;
            }
        }
        for (int y = intervalbelow; y <= intervalabove; y++)
        {
            Console.Write(op12[y] + " ");
        }
        Console.WriteLine(" ");
        Console.Write("Number of codons in the gene : " + shortestgene);
        Console.WriteLine(" ");
        Console.Write("Position of the gene         : " + (intervalbelow + 1));
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        string[] op12 = new string[auxillaryStrand_2.Length / 3];
        string concencrate = "";
        int numberofgenes = 0;
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\nShortest gene                : ");
        for (int i = 0; i < auxillaryStrand_2.Length; i += 3)
        {
            concencrate += auxillaryStrand_2[i];
            concencrate += auxillaryStrand_2[i + 1];
            concencrate += auxillaryStrand_2[i + 2];
            op12[i / 3] = concencrate;
            concencrate = "";
        }
        int k = 0;
        int lengthofgene = 0;
        int shortestgene = 99;
        int intervalbelow = 0;
        int intervalabove = 0;
        for (int x = 0; x < op12.Length; x++)
        {
            for (int i = k; i < (op12.Length); i++)
            {
                bool flagop12 = false;
                if (op12[i] == "ATG")
                {

                    for (int j = i; j < op12.Length; j++)
                    {
                        if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                        {
                            numberofgenes++;
                            k = j;
                            flagop12 = true;
                            lengthofgene = j - i + 1;
                            if (lengthofgene < shortestgene)
                            {
                                shortestgene = lengthofgene;
                                intervalbelow = i;
                                intervalabove = j;
                            }
                            break;
                        }
                    }
                }
                if (flagop12 == true)
                    break;
            }
        }
        for (int y = intervalbelow; y <= intervalabove; y++)
        {
            Console.Write(op12[y] + " ");
        }
        Console.WriteLine(" ");
        Console.Write("Number of codons in the gene : " + shortestgene);
        Console.WriteLine(" ");
        Console.Write("Position of the gene         : " + (intervalbelow + 1));
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        string[] op12 = new string[auxillaryStrand_3.Length / 3];
        string concencrate = "";
        int numberofgenes = 0;
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\nShortest gene                : ");
        for (int i = 0; i < auxillaryStrand_3.Length; i += 3)
        {
            concencrate += auxillaryStrand_3[i];
            concencrate += auxillaryStrand_3[i + 1];
            concencrate += auxillaryStrand_3[i + 2];
            op12[i / 3] = concencrate;
            concencrate = "";
        }
        int k = 0;
        int lengthofgene = 0;
        int shortestgene = 99;
        int intervalbelow = 0;
        int intervalabove = 0;
        for (int x = 0; x < op12.Length; x++)
        {
            for (int i = k; i < (op12.Length); i++)
            {
                bool flagop12 = false;
                if (op12[i] == "ATG")
                {

                    for (int j = i; j < op12.Length; j++)
                    {
                        if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                        {
                            numberofgenes++;
                            k = j;
                            flagop12 = true;
                            lengthofgene = j - i + 1;
                            if (lengthofgene < shortestgene)
                            {
                                shortestgene = lengthofgene;
                                intervalbelow = i;
                                intervalabove = j;
                            }
                            break;
                        }
                    }
                }
                if (flagop12 == true)
                    break;
            }
        }
        for (int y = intervalbelow; y <= intervalabove; y++)
        {
            Console.Write(op12[y] + " ");
        }
        Console.WriteLine(" ");
        Console.Write("Number of codons in the gene : " + shortestgene);
        Console.WriteLine(" ");
        Console.Write("Position of the gene         : " + (intervalbelow + 1));
    }
}

// Operation 14
void longestGene()
{
    if (mainStrand.Length != 0)
    {
        string[] op12 = new string[mainStrand.Length / 3];
        string concencrate = "";
        int numberofgenes = 0;
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\nLongest gene                 : ");
        for (int i = 0; i < mainStrand.Length; i += 3)
        {
            concencrate += mainStrand[i];
            concencrate += mainStrand[i + 1];
            concencrate += mainStrand[i + 2];
            op12[i / 3] = concencrate;
            concencrate = "";
        }
        int k = 0;
        int lengthofgene = 0;
        int longestgene = 0;
        int intervalbelow = 0;
        int intervalabove = 0;
        for (int x = 0; x < op12.Length; x++)
        {
            for (int i = k; i < (op12.Length); i++)
            {
                bool flagop12 = false;
                if (op12[i] == "ATG")
                {
                    for (int j = i; j < op12.Length; j++)
                    {
                        if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                        {
                            numberofgenes++;
                            k = j;
                            flagop12 = true;
                            lengthofgene = j - i + 1;
                            if (lengthofgene > longestgene)
                            {
                                longestgene = lengthofgene;
                                intervalbelow = i;
                                intervalabove = j;
                            }
                            break;
                        }
                    }
                }
                if (flagop12 == true)
                    break;
            }
        }
        for (int y = intervalbelow; y <= intervalabove; y++)
        {
            Console.Write(op12[y] + " ");
        }
        Console.WriteLine(" ");
        Console.Write("Number of codons in the gene : " + longestgene);
        Console.WriteLine(" ");
        Console.Write("Position of the gene         : " + (intervalbelow + 1));
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        string[] op12 = new string[auxillaryStrand_2.Length / 3];
        string concencrate = "";
        int numberofgenes = 0;
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\nLongest gene                 : ");
        for (int i = 0; i < auxillaryStrand_2.Length; i += 3)
        {
            concencrate += auxillaryStrand_2[i];
            concencrate += auxillaryStrand_2[i + 1];
            concencrate += auxillaryStrand_2[i + 2];
            op12[i / 3] = concencrate;
            concencrate = "";
        }
        int k = 0;
        int lengthofgene = 0;
        int longestgene = 0;
        int intervalbelow = 0;
        int intervalabove = 0;
        for (int x = 0; x < op12.Length; x++)
        {
            for (int i = k; i < (op12.Length); i++)
            {
                bool flagop12 = false;
                if (op12[i] == "ATG")
                {

                    for (int j = i; j < op12.Length; j++)
                    {
                        if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                        {
                            numberofgenes++;
                            k = j;
                            flagop12 = true;
                            lengthofgene = j - i + 1;
                            if (lengthofgene > longestgene)
                            {
                                longestgene = lengthofgene;
                                intervalbelow = i;
                                intervalabove = j;
                            }
                            break;
                        }
                    }
                }
                if (flagop12 == true)
                    break;
            }
        }
        for (int y = intervalbelow; y <= intervalabove; y++)
        {
            Console.Write(op12[y] + " ");
        }
        Console.WriteLine(" ");
        Console.Write("Number of codons in the gene : " + longestgene);
        Console.WriteLine(" ");
        Console.Write("Position of the gene         : " + (intervalbelow + 1));
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        string[] op12 = new string[auxillaryStrand_3.Length / 3];
        string concencrate = "";
        int numberofgenes = 0;
        Console.Write("DNA Strand : ");
        Space();
        Console.WriteLine(" ");
        Console.Write("\nLongest gene                 : ");
        for (int i = 0; i < auxillaryStrand_3.Length; i += 3)
        {
            concencrate += auxillaryStrand_3[i];
            concencrate += auxillaryStrand_3[i + 1];
            concencrate += auxillaryStrand_3[i + 2];
            op12[i / 3] = concencrate;
            concencrate = "";
        }
        int k = 0;
        int lengthofgene = 0;
        int longestgene = 0;
        int intervalbelow = 0;
        int intervalabove = 0;
        for (int x = 0; x < op12.Length; x++)
        {
            for (int i = k; i < (op12.Length); i++)
            {
                bool flagop12 = false;
                if (op12[i] == "ATG")
                {

                    for (int j = i; j < op12.Length; j++)
                    {
                        if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                        {
                            numberofgenes++;
                            k = j;
                            flagop12 = true;
                            lengthofgene = j - i + 1;
                            if (lengthofgene > longestgene)
                            {
                                longestgene = lengthofgene;
                                intervalbelow = i;
                                intervalabove = j;
                            }
                            break;
                        }
                    }
                }
                if (flagop12 == true)
                    break;
            }
        }
        for (int y = intervalbelow; y <= intervalabove; y++)
        {
            Console.Write(op12[y] + " ");
        }
        Console.WriteLine(" ");
        Console.Write("Number of codons in the gene : " + longestgene);
        Console.WriteLine(" ");
        Console.Write("Position of the gene         : " + (intervalbelow + 1));
    }
}

// Operation 15
void repeated_nucleotide()
{
    if (mainStrand.Length != 0)
    {
        Console.Write("DNA Strand : ");
        Space();
        Console.Write("\n");
        Console.Write("\nEnter number of nucleotide : ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] sequencechecker = new string[mainStrand.Length + 1 - n];
        int counter = 1;
        int[] sequencecounter = new int[read1.Length + 1 - n];

        for (int i = 0; i < read1.Length; i++)  // getting the string character by character
        {
            mainStrand[i] = read1[i];
        }

        string sequence = "";

        for (int i = 0; i < mainStrand.Length + 1 - n; i++)
        {
            for (int j = i; j < i + n; j++)
            {
                sequence += mainStrand[j];
            }
            sequencechecker[i] = sequence;
            sequence = "";
        }

        int checkpoint = 0;

        for (int i = 0; i < sequencechecker.Length; i++)
        {
            for (int x = 0; x < sequencechecker.Length; x++)
            {
                for (int j = i; j + 1 < sequencechecker.Length; j++)
                {
                    if (sequencechecker[i] == sequencechecker[j])
                    {
                        counter++;
                        sequencecounter[i] = counter;
                        j += n - 1;
                    }
                }
                checkpoint = 0;
                counter = 1;
            }
        }

        int maxValue = sequencecounter.Max();
        int frequency = maxValue - 1;
        int index = Array.IndexOf(sequencecounter, maxValue);

        Console.WriteLine(" ");
        Console.WriteLine("Most repeated sequence : " + sequencechecker[index]);
        Console.WriteLine("\nFrequency : " + frequency);

        Console.WriteLine(" ");
    }
    else if (auxillaryStrand_2.Length != 0)
    {
        Console.Write("DNA Strand : ");
        Space();
        Console.Write("\n");
        Console.Write("\nEnter number of nucleotide : ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] sequencechecker = new string[auxillaryStrand_2.Length + 1 - n];
        int counter = 1;
        int[] sequencecounter = new int[read2.Length + 1 - n];

        for (int i = 0; i < read2.Length; i++)  // getting the string character by character
        {
            auxillaryStrand_2[i] = read2[i];
        }

        string sequence = "";

        for (int i = 0; i < auxillaryStrand_2.Length + 1 - n; i++)
        {
            for (int j = i; j < i + n; j++)
            {
                sequence += auxillaryStrand_2[j];
            }
            sequencechecker[i] = sequence;
            sequence = "";
        }

        int checkpoint = 0;

        for (int i = 0; i < sequencechecker.Length; i++)
        {
            for (int x = 0; x < sequencechecker.Length; x++)
            {
                for (int j = i; j + 1 < sequencechecker.Length; j++)
                {
                    if (sequencechecker[i] == sequencechecker[j])
                    {
                        counter++;
                        sequencecounter[i] = counter;
                        j += n - 1;
                    }
                }
                checkpoint = 0;
                counter = 1;
            }
        }

        int maxValue = sequencecounter.Max();
        int frequency = maxValue - 1;
        int index = Array.IndexOf(sequencecounter, maxValue);

        Console.WriteLine(" ");
        Console.WriteLine("Most repeated sequence : " + sequencechecker[index]);
        Console.WriteLine("\nFrequency : " + frequency);

        Console.WriteLine(" ");
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        Console.Write("DNA Strand : ");
        Space();
        Console.Write("\n");
        Console.Write("\nEnter number of nucleotide : ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] sequencechecker = new string[auxillaryStrand_3.Length + 1 - n];
        int counter = 1;
        int[] sequencecounter = new int[read3.Length + 1 - n];

        for (int i = 0; i < read3.Length; i++)  // getting the string character by character
        {
            auxillaryStrand_3[i] = read3[i];
        }

        string sequence = "";

        for (int i = 0; i < auxillaryStrand_3.Length + 1 - n; i++)
        {
            for (int j = i; j < i + n; j++)
            {
                sequence += mainStrand[j];
            }
            sequencechecker[i] = sequence;
            sequence = "";
        }

        int checkpoint = 0;

        for (int i = 0; i < sequencechecker.Length; i++)
        {
            for (int x = 0; x < sequencechecker.Length; x++)
            {
                for (int j = i; j + 1 < sequencechecker.Length; j++)
                {
                    if (sequencechecker[i] == sequencechecker[j])
                    {
                        counter++;
                        sequencecounter[i] = counter;
                        j += n - 1;
                    }
                }
                checkpoint = 0;
                counter = 1;
            }
        }

        int maxValue = sequencecounter.Max();
        int frequency = maxValue - 1;
        int index = Array.IndexOf(sequencecounter, maxValue);

        Console.WriteLine(" ");
        Console.WriteLine("Most repeated sequence : " + sequencechecker[index]);
        Console.WriteLine("\nFrequency : " + frequency);

        Console.WriteLine(" ");
    }
}

// Operation 16
void HydrogenBond()
{
    if (mainStrand.Length != 0)
    {
        for (int i = 0; i < mainStrand.Length; i++)
        {
            if (mainStrand[i] == 'A' || mainStrand[i] == 'T')
                two_hydrogenBond++;
            else
                three_hydrogenBond++;
        }
        // Hydrogen bonds of A and T
        Console.WriteLine("Number of pairing with 2-hydrogen bonds:" + two_hydrogenBond);
        // Hydrogen bonds of C and G
        Console.WriteLine("Number of pairing with 3-hydrogen bonds:" + three_hydrogenBond);
        // Sum of Hydrogen bonds
        sum_hydrogenBond = two_hydrogenBond * 2 + three_hydrogenBond * 3;
        Console.WriteLine("Number of hydrogen bonds:" + sum_hydrogenBond);
    } 
    else if (auxillaryStrand_2.Length != 0)
    {
        for (int i = 0; i < auxillaryStrand_2.Length; i++)
        {
            if (auxillaryStrand_2[i] == 'A' || auxillaryStrand_2[i] == 'T')
                two_hydrogenBond++;
            else
                three_hydrogenBond++;
        }
        // Hydrogen bonds of A and T
        Console.WriteLine("Number of pairing with 2-hydrogen bonds:" + two_hydrogenBond);
        // Hydrogen bonds of C and G
        Console.WriteLine("Number of pairing with 3-hydrogen bonds:" + three_hydrogenBond);
        // Sum of Hydrogen bonds
        sum_hydrogenBond = two_hydrogenBond * 2 + three_hydrogenBond * 3;
        Console.WriteLine("Number of hydrogen bonds:" + sum_hydrogenBond);
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        for (int i = 0; i < auxillaryStrand_3.Length; i++)
        {
            if (auxillaryStrand_3[i] == 'A' || auxillaryStrand_3[i] == 'T')
                two_hydrogenBond++;
            else
                three_hydrogenBond++;
        }
        // Hydrogen bonds of A and T
        Console.WriteLine("Number of pairing with 2-hydrogen bonds:" + two_hydrogenBond);
        // Hydrogen bonds of C and G
        Console.WriteLine("Number of pairing with 3-hydrogen bonds:" + three_hydrogenBond);
        // Sum of Hydrogen bonds
        sum_hydrogenBond = two_hydrogenBond * 2 + three_hydrogenBond * 3;
        Console.WriteLine("Number of hydrogen bonds:" + sum_hydrogenBond);
    }
}

// Operation 17
void BLOB_Generations()
{
    for (int i = 0; i < mainStrand.Length; i++)
    {
        Strand1[i] = mainStrand[i];
    }
    for (int i = 0; i < auxillaryStrand_2.Length; i++)
    {
        Strand2[i] = auxillaryStrand_2[i];
    }



    char[] Strand3 = new char[200];
    bool flagop17 = false;
    int generationnumber = 1;


    for (int i = 0; i < 10; i++) // Main loop.
    {
        generations();
        if (flagop17 == true)
            break;
    }
    if (flagop17 == false)
    {
        Console.WriteLine("Generations are completed.");
    }


    void generations()
    {
        for (int i = 0; i < 6; i++) // Taking the start codon and the first gene codon from strand 1
        {
            Strand3[i] = Strand1[i];
        }
        for (int i = 6; i < 12; i++) // Taking the second gene codon and stop coodn from the strand 2
        {
            Strand3[i] = Strand2[i];
        }


        string checker = "";
        int strand1genenumber = 0;
        int strand2genenumber = 0;
        int maxgenenumber = 0;

        strand1genenumber = geneNumberr(Strand1);
        strand2genenumber = geneNumberr(Strand2);


        if (strand1genenumber > strand2genenumber) //Finding the maximum gene number.
        {
            maxgenenumber = strand1genenumber;
        }
        if (strand1genenumber <= strand2genenumber) //Finding the maximum gene number.
        {
            maxgenenumber = strand2genenumber;
        }


        int indexstartposition1 = 0;
        int indexstartposition2 = 0;
        int indexendposition1 = 0;
        int indexendposition2 = 0;
        int genecounter = 2;
        int numberofcycle = 0;
        int startposition = 0;
        bool flag2 = true;
        bool flag1 = true;


        void strand2addition(int x) // Adding the next gene from the second strand.
        {
            flag1 = true;
            for (int g = 0; g < x; g++)
            {

                for (int i = indexendposition2; i < Strand2.Length - 3; i += 3)
                {
                    checker = checker + Strand2[i] + Strand2[i + 1] + Strand2[i + 2];
                    numberofcycle += 3;
                    if (checker == "TAA" || checker == "TAG" || checker == "TGA")
                    {
                        indexendposition2 = i + 3; // Finding the ending position of the gene.
                        indexstartposition2 = i - numberofcycle + 3; // Finding the starting position of the gene.
                        i = indexendposition2; // Assigning the ending position to i to make it start from the next gene.
                        numberofcycle = 0;
                        break;
                    }
                    checker = "";
                    if (i == Strand2.Length - 1)
                        break;
                }
            }

            for (int a = indexstartposition2; a < indexendposition2; a++) // Adding the gene to the Strand3.
            {
                Strand3[12 + a - indexstartposition2 + startposition] = Strand2[a]; //12 + a - indexstartposition2 + startposition is there to find the needed start point of addition.
            }
            startposition = startposition + indexendposition2 - indexstartposition2; //Adding the length of the gene to start position to use for positioning later.
            genecounter++; //Increasing the genecounter to get the next gene from the blobs.
            indexstartposition2 = 0;
            indexendposition2 = 0;
        }

        void strand1addition(int x) // Adding the next gene from the first strand. All the details inside is same as above.
        {

            for (int g = 0; g < x; g++)
            {
                for (int i = indexendposition1; i < Strand1.Length - 3; i += 3)
                {
                    checker = checker + Strand1[i] + Strand1[i + 1] + Strand1[i + 2];
                    numberofcycle += 3;
                    if (checker == "TAA" || checker == "TAG" || checker == "TGA")
                    {
                        indexendposition1 = i + 3;
                        indexstartposition1 = i - numberofcycle + 3;
                        i = indexendposition1;
                        numberofcycle = 0;
                        break;
                    }
                    checker = "";
                    if (i == Strand2.Length - 1)
                        break;
                }
            }
            for (int a = indexstartposition1; a < indexendposition1; a++)
            {
                Strand3[12 + a - indexstartposition1 + startposition] = Strand1[a];
            }
            startposition = startposition + indexendposition1 - indexstartposition1;
            genecounter++;
            indexstartposition1 = 0;
            indexendposition1 = 0;
        }

        for (int i = 2; i < 100; i++)
        {
            if (strand1genenumber >= genecounter)
            {
                strand1addition(genecounter);
            }
            else flag1 = false;

            if (genecounter == (maxgenenumber + 1))
            {
                break;
            }

            if (strand2genenumber >= genecounter)
            {
                strand2addition(genecounter);
            }
            else flag2 = false;

            if (genecounter == (maxgenenumber + 1))
            {
                break;
            }



            if (flag1 == false && flag2 == false)
            {
                break;
            }
        }

        string concencrate = "";
        string[] strand3array = new string[Strand3.Length / 3];
        int j = 0;
        int count = 0;
        double riskycodon = 0;
        int codoncount = 0;


        for (int i = 0; i < Strand3.Length - 2; i += 3)
        {
            concencrate = concencrate + Strand3[i] + Strand3[i + 1] + Strand3[i + 2];
            strand3array[j] = concencrate;
            j++;
            concencrate = "";
        }

        for (int i = 0; i < strand3array.Length; i++)
        {
            if (strand3array[i] != "\0\0\0") //Finding the actual number of codons in the strand3
            {
                codoncount++;
            }
            if (strand3array[i] == "GGG" || strand3array[i] == "GGC" || strand3array[i] == "GCG" || strand3array[i] == "CGG" || strand3array[i] == "CCG" || strand3array[i] == "CGC" || strand3array[i] == "GCC" || strand3array[i] == "CCC")
            {
                // Checking for the consecutive codons with all 3 hydrogen bonds.
                count++;
                if (count > 2)
                {
                    riskycodon = 3 + count; // Finding the amount of risky codons.
                }
            }
            else
            {
                count = 0;
            }
        }

        double faultratio = 100 * riskycodon / codoncount; // Finding the faulty codon ratio.

        string Strand1status = "";
        string Strand2status = "";
        string Strand3status = "";
        string Strand1gender = "";
        string Strand2gender = "";
        string Strand3gender = "";

        // Controlling the genders of each blob.
        if (Strand1[3] == 'A' && Strand1[4] == 'A' && Strand1[5] == 'A' || Strand1[3] == 'T' && Strand1[4] == 'T' && Strand1[5] == 'T')
        {
            Strand1status += "X";
        }
        if (Strand1[3] == 'G' && Strand1[4] == 'G' && Strand1[5] == 'G' || Strand1[3] == 'C' && Strand1[4] == 'C' && Strand1[5] == 'C')
        {
            Strand1status += "Y";
        }
        if (Strand1[6] == 'A' && Strand1[7] == 'A' && Strand1[8] == 'A' || Strand1[6] == 'T' && Strand1[7] == 'T' && Strand1[8] == 'T')
        {
            Strand1status += "X";
        }
        if (Strand1[6] == 'G' && Strand1[7] == 'G' && Strand1[8] == 'G' || Strand1[6] == 'C' && Strand1[7] == 'C' && Strand1[8] == 'C')
        {
            Strand1status += "Y";
        }

        if (Strand2[3] == 'A' && Strand2[4] == 'A' && Strand2[5] == 'A' || Strand2[3] == 'T' && Strand2[4] == 'T' && Strand2[5] == 'T')
        {
            Strand2status += "X";
        }
        if (Strand2[3] == 'G' && Strand2[4] == 'G' && Strand2[5] == 'G' || Strand2[3] == 'C' && Strand2[4] == 'C' && Strand2[5] == 'C')
        {
            Strand2status += "Y";
        }
        if (Strand2[6] == 'A' && Strand2[7] == 'A' && Strand2[8] == 'A' || Strand2[6] == 'T' && Strand2[7] == 'T' && Strand2[8] == 'T')
        {
            Strand2status += "X";
        }
        if (Strand2[6] == 'G' && Strand2[7] == 'G' && Strand2[8] == 'G' || Strand2[6] == 'C' && Strand2[7] == 'C' && Strand2[8] == 'C')
        {
            Strand2status += "Y";
        }

        if (Strand3[3] == 'A' && Strand3[4] == 'A' && Strand3[5] == 'A' || Strand3[3] == 'T' && Strand3[4] == 'T' && Strand3[5] == 'T')
        {
            Strand3status += "X";
        }
        if (Strand3[3] == 'G' && Strand3[4] == 'G' && Strand3[5] == 'G' || Strand3[3] == 'C' && Strand3[4] == 'C' && Strand3[5] == 'C')
        {
            Strand3status += "Y";
        }
        if (Strand3[6] == 'A' && Strand3[7] == 'A' && Strand3[8] == 'A' || Strand3[6] == 'T' && Strand3[7] == 'T' && Strand3[8] == 'T')
        {
            Strand3status += "X";
        }
        if (Strand3[6] == 'G' && Strand3[7] == 'G' && Strand3[8] == 'G' || Strand3[6] == 'C' && Strand3[7] == 'C' && Strand3[8] == 'C')
        {
            Strand3status += "Y";
        }


        if (Strand1status == "XY" || Strand1status == "YX")
        {
            Strand1gender = "male";
        }
        else if (Strand1status == "XX")
        {
            Strand1gender = "female";
        }
        else Strand1gender = "invalid";

        if (Strand2status == "XY" || Strand2status == "YX")
        {
            Strand2gender = "male";
        }
        else if (Strand2status == "XX")
        {
            Strand2gender = "female";
        }
        else Strand2gender = "invalid";

        if (Strand3status == "XY" || Strand3status == "YX")
        {
            Strand3gender = "male";
        }
        else if (Strand3status == "XX")
        {
            Strand3gender = "female";
        }
        else Strand3gender = "invalid";


        if (Strand1gender == Strand2gender)
        {
            Console.WriteLine("Both BLOBS are " + Strand1gender + ". Please try again with 1 male and 1 female BLOB.");
            flagop17 = true;
            return;
        }

        if (Strand1gender == "invalid" || Strand2gender == "invalid")
        {
            Console.WriteLine("BLOB gender error. Please try again with valid BLOBs.");
            flagop17 = true;
            return;
        }


        Console.WriteLine("Generation " + generationnumber + " : ");
        Console.Write("BLOB1-" + Strand1status + " : ");
        for (int i = 0; i < Strand1.Length; i++)
        {
            Console.Write(Strand1[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
        Console.WriteLine(" ");
        Console.Write("BLOB2-" + Strand2status + " : ");
        for (int i = 0; i < Strand2.Length; i++)
        {
            Console.Write(Strand2[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
        Console.WriteLine("");
        Console.Write("BLOB3-" + Strand3status + " : ");
        for (int i = 0; i < Strand3.Length; i++)
        {
            Console.Write(Strand3[i]);
            if (i % 3 == 2)
                Console.Write(" ");
        }
        Console.WriteLine("");
        Console.WriteLine("BLOB3 faulty codons ratio = " + riskycodon + "/" + codoncount + " = " + faultratio + "%");
        if (faultratio > 10)
        {
            Console.WriteLine("Newborn dies. Generations are over.");
            flagop17 = true;
        }
        Console.WriteLine("");

        generationnumber++;

        Strand1 = Strand3;

        if (Strand3gender == "male")
        {
            string randomfemale = Generate_BLOB_newborn_femaleop17();
            for (int i = 0; i < randomfemale.Length; i++)
            {
                Strand2[i] = randomfemale[i];
                Strand3 = new char[700];
            }

        }
        if (Strand3gender == "female")
        {
            string randommale = Generate_BLOB_newborn_maleop17();
            for (int i = 0; i < randommale.Length; i++)
            {
                Strand2[i] = randommale[i];
                Strand3 = new char[700];
            }

        }

    }




    string Generate_BLOB_newborn_femaleop17()
    {
        Random rnd = new Random();

        // randomly selecting the stop codons
        int index_stopCodons = rnd.Next(Stop_Codons.Length);

        // middle genes
        string[] femalegenderGene = { "AAA", "TTT", "GGG", "CCC" };

        // randomly selecting middle codons - second codon
        int index_middleCodons_1 = rnd.Next(femalegenderGene.Length);

        // randomly selecting middle codons - third codon
        int index_middleCodons_2 = rnd.Next(femalegenderGene.Length);

        // other codons
        string[] otherCodon = new string[] { "A", "T", "C", "G" };

        // Generating String for other codons
        string concencrate = "";
        string mainconcencrate = "";

        /// New born baby DNA
        string newBornGene_female = Met_Start_Codons + femalegenderGene[index_middleCodons_1] + femalegenderGene[index_middleCodons_2] + Stop_Codons[index_stopCodons];


        // Randomly selecting the number of  other codons in a gene from 1 to 4
        int randomNumbOfCodons = rnd.Next(1, 5);
        int genderRand = rnd.Next(1, 6);
        for (int h = 0; h < genderRand; h++)
        {
            mainconcencrate = "";
            concencrate = "";
            for (int i = 0; i <= randomNumbOfCodons; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    // randomly selecting codons
                    int index_otherCodons = rnd.Next(otherCodon.Length);
                    concencrate += otherCodon[index_otherCodons];

                }
                for (int x = 0; x < concencrate.Length - 3; x += 3)
                {
                    if ((concencrate[x] == startcodon[0] && concencrate[x + 1] == startcodon[1] && concencrate[x + 2] == startcodon[2]) || (concencrate[x] == stopCodon1[0] && concencrate[x + 1] == stopCodon1[1] && concencrate[x + 2] == stopCodon1[2]) || (concencrate[x] == stopCodon2[0] && concencrate[x + 1] == stopCodon2[1] && concencrate[x + 2] == stopCodon2[2]) || (concencrate[x] == stopCodon3[0] && concencrate[x + 1] == stopCodon3[1] && concencrate[x + 2] == stopCodon3[2]))
                    {
                        concencrate = "CGA";
                    }
                }


            }

            mainconcencrate = concencrate;
            newBornGene_female += Met_Start_Codons + mainconcencrate + Stop_Codons[index_stopCodons];
        }

        // AAA or TTT = X ---- GGG or CCC = Y
        // gender ? XX female ---- XY or YX male
        if ((femalegenderGene[index_middleCodons_1] == "AAA" || femalegenderGene[index_middleCodons_1] == "TTT") && (femalegenderGene[index_middleCodons_2] == "AAA" || femalegenderGene[index_middleCodons_2] == "TTT"))
        {
            return newBornGene_female;
        }
        else return Generate_BLOB_newborn_femaleop17();
    }



    string Generate_BLOB_newborn_maleop17()
    {
        Random rnd = new Random();

        // randomly selecting the stop codons
        int index_stopCodons = rnd.Next(Stop_Codons.Length);

        // middle genes
        string[] malegenderGene = { "AAA", "TTT", "GGG", "CCC" };

        // randomly selecting middle codons - second codon
        int index_middleCodons_1 = rnd.Next(malegenderGene.Length);

        // randomly selecting middle codons - third codon
        int index_middleCodons_2 = rnd.Next(malegenderGene.Length);

        // other codons
        string[] otherCodon = new string[] { "A", "T", "C", "G" };

        // Generating String for other codons
        string concencrate = "";
        string mainconcencrate = "";

        /// New born baby DNA
        string newBornGene_male = Met_Start_Codons + malegenderGene[index_middleCodons_1] + malegenderGene[index_middleCodons_2] + Stop_Codons[index_stopCodons];
        while (true)
        {
            if ((malegenderGene[index_middleCodons_1] == "GGG" || malegenderGene[index_middleCodons_1] == "CCC") && (malegenderGene[index_middleCodons_2] == "GGG" || malegenderGene[index_middleCodons_2] == "CCC"))
            {
                index_middleCodons_1 = rnd.Next(malegenderGene.Length);
                index_middleCodons_2 = rnd.Next(malegenderGene.Length);
                newBornGene_male = Met_Start_Codons + malegenderGene[index_middleCodons_1] + malegenderGene[index_middleCodons_2] + Stop_Codons[index_stopCodons];
            }
            else if ((malegenderGene[index_middleCodons_1] == "TTT" || malegenderGene[index_middleCodons_1] == "AAA") && (malegenderGene[index_middleCodons_2] == "TTT" || malegenderGene[index_middleCodons_2] == "AAA"))
            {
                index_middleCodons_1 = rnd.Next(malegenderGene.Length);
                index_middleCodons_2 = rnd.Next(malegenderGene.Length);
                newBornGene_male = Met_Start_Codons + malegenderGene[index_middleCodons_1] + malegenderGene[index_middleCodons_2] + Stop_Codons[index_stopCodons];
            }
            else
                break;
        }


        // Randomly selecting the number of  other codons in a gene from 1 to 4
        int randomNumbOfCodons = rnd.Next(1, 5);
        int genderRand = rnd.Next(1, 6);
        for (int h = 0; h < genderRand; h++)
        {
            mainconcencrate = "";
            concencrate = "";
            for (int i = 0; i <= randomNumbOfCodons; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    // randomly selecting codons
                    int index_otherCodons = rnd.Next(otherCodon.Length);
                    concencrate += otherCodon[index_otherCodons];

                }
                for (int x = 0; x < concencrate.Length - 3; x += 3)
                {
                    if ((concencrate[x] == startcodon[0] && concencrate[x + 1] == startcodon[1] && concencrate[x + 2] == startcodon[2]) || (concencrate[x] == stopCodon1[0] && concencrate[x + 1] == stopCodon1[1] && concencrate[x + 2] == stopCodon1[2]) || (concencrate[x] == stopCodon2[0] && concencrate[x + 1] == stopCodon2[1] && concencrate[x + 2] == stopCodon2[2]) || (concencrate[x] == stopCodon3[0] && concencrate[x + 1] == stopCodon3[1] && concencrate[x + 2] == stopCodon3[2]))
                    {
                        concencrate = "CGA";
                    }
                }


            }

            mainconcencrate = concencrate;
            newBornGene_male += Met_Start_Codons + mainconcencrate + Stop_Codons[index_stopCodons];
        }

        // AAA or TTT = X ---- GGG or CCC = Y
        // gender ? XX female ---- XY or YX male
        if (((malegenderGene[index_middleCodons_1] == "AAA" || malegenderGene[index_middleCodons_1] == "TTT") && (malegenderGene[index_middleCodons_2] == "CCC" || malegenderGene[index_middleCodons_2] == "GGG")) || ((malegenderGene[index_middleCodons_1] == "CCC" || malegenderGene[index_middleCodons_1] == "GGG") && (malegenderGene[index_middleCodons_2] == "AAA" || malegenderGene[index_middleCodons_2] == "TTT")))
        {
            return newBornGene_male;
        }
        else return Generate_BLOB_newborn_maleop17();

    }
    int geneNumberr(char[] strand)
    {
        {


            string[] op12 = new string[strand.Length / 3];
            string concencrate = "";
            int numberofgenesop17 = 0;
            for (int i = 0; i < strand.Length - 3; i += 3)
            {
                concencrate += strand[i];
                concencrate += strand[i + 1];
                concencrate += strand[i + 2];
                op12[i / 3] = concencrate;
                concencrate = "";
            }
            int k = 0;
            for (int x = 0; x < op12.Length; x++)
            {
                for (int i = k; i < (op12.Length); i++)
                {
                    bool flagop12 = false;
                    if (op12[i] == "ATG")
                    {
                        for (int j = i; j < op12.Length; j++)
                        {
                            if (op12[j] == "TAA" || op12[j] == "TGA" || op12[j] == "TAG")
                            {
                                numberofgenesop17++;
                                k = j;
                                flagop12 = true;
                                break;
                            }
                        }
                    }
                    if (flagop12 == true)
                        break;
                }
            }
            return numberofgenesop17;
        }
    }
}

//Controling the entry of DNA
bool control_function()
{
    bool flag3 = false;
    if (mainStrand.Length != 0)
    {

        for (int i = 1; i < mainStrand.Length; i++)
        {
            mainStrand[i - 1] = read1[i - 1];

            if (mainStrand[i - 1] == 'A' || mainStrand[i - 1] == 'G' || mainStrand[i - 1] == 'C' || mainStrand[i - 1] == 'T')
            {
                flag3 = true;
            }
            else
            {
                flag3 = false;
                break;
            }

        }
    }
    if (auxillaryStrand_2.Length != 0)
    {
        for (int i = 1; i < auxillaryStrand_2.Length; i++)
        {
            auxillaryStrand_2[i - 1] = read2[i - 1];

            if (auxillaryStrand_2[i - 1] == 'A' || auxillaryStrand_2[i - 1] == 'G' || auxillaryStrand_2[i - 1] == 'C' || auxillaryStrand_2[i - 1] == 'T')
            {
                flag3 = true;
            }
            else
            {
                flag3 = false;
                break;
            }

        }
    }
    else if (auxillaryStrand_3.Length != 0)
    {
        for (int i = 1; i < auxillaryStrand_3.Length; i++)
        {
            auxillaryStrand_3[i - 1] = read3[i - 1];

            if (auxillaryStrand_3[i - 1] == 'A' || auxillaryStrand_3[i - 1] == 'G' || auxillaryStrand_3[i - 1] == 'C' || auxillaryStrand_3[i - 1] == 'T')
            {
                flag3 = true;
            }
            else
            {
                flag3 = false;
                break;
            }
        }
    }
    return flag3;
}

// Space - Output showing spaces between the DNA string
void Space()
{
    if (mainStrand.Length != 0)
    {
        int count = 1;
        for (int i = 1; i <= mainStrand.Length; i++)
        {
            char a = mainStrand[i - 1];
            Console.Write(a);
            while (count % 3 == 0)
            {
                Console.Write(" ");
                break;
            }
            count++;
        }

    }
    else if (auxillaryStrand_2.Length != 0)
    {

        int count = 1;
        for (int i = 1; i <= auxillaryStrand_2.Length; i++)
        {
            char a = auxillaryStrand_2[i - 1];
            Console.Write(a);
            while (count % 3 == 0)
            {
                Console.Write(" ");
                break;
            }
            count++;
        }



    }
    else if (auxillaryStrand_3.Length != 0)
    {
        int count = 1;
        for (int i = 1; i <= auxillaryStrand_3.Length; i++)
        {
            char a = auxillaryStrand_3[i - 1];
            Console.Write(a);
            while (count % 3 == 0)
            {
                Console.Write(" ");
                break;
            }
            count++;
        }

    }
}

Console.ReadKey();