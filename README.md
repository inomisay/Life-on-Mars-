# Life on Mars!
<img width="132" alt="Screen Shot 2023-05-31 at 15 39 03" src="https://github.com/inomisay/Life-on-Mars-/assets/98346164/df0f9505-b329-468d-99cc-673c94bb75ec">

# Project:  Life on Mars!

The aim of the project is to develop a simplified/modified 
DNA operations/simulations on a hypothetical organism. 

News from Mars: Our spaceship discovers a new life form on Mars.
This being (called BLOB) has single cell and single chromosome.

#  General Information

The genetic code is carried by DNA (DeoxyriboNucleic Acid) molecules. The DNA language has an alphabet of four symbols or “letters”: A, C, G and T, which are ordered to convey a specific piece of information. In our human cells, these four DNA letters are linked together in a precise order in very long molecular chains, which convey genetic information to our cells.

There are 4 nucleotide bases in DNA. These are Adenine (A), Thymine (T), Cytosine (C) and Guanine (G). Each nucleotide only connects/pairs with its corresponding nucleotide on the opposite DNA strand. A is always paired with T and C is always paired with G. There are two hydrogen bonds between A-T and three hydrogen bonds between C-G.

When cells synthesize proteins, they use DNA codons. Codons are a group of 3 nucleotides. They represent a specific amino acid (proteins are made up of amino acids) that can be synthesized through cell organelle called ribosome. Genes are codon sequences which start with ATG (Methionine - Start codon) and end with one of the Stop codons (TAA, TGA or TAG). We can say that nucleotides are letters of the language, codons are words and genes are paragraphs.

<img width="970" alt="Screen Shot 2023-05-31 at 15 44 05" src="https://github.com/inomisay/Life-on-Mars-/assets/98346164/d950b980-cd49-4134-bf6c-878edcd88042">


#  DNA Operations

Generally, operations and simulations are based on codons (3 nucleotides) not single nucleotides. DNA strand 1 is the main strand, 2 and 3 are auxiliary strands. At the end of operations, changes are kept.

**Operation 1.** Load a DNA sequence from a file

Command: **Load 1 dna1.txt**  (load dna1.txt file content to DNA strand 1 (main strand))
dna1.txt: "ATGACTGATGAGAGATATTGA"

**Operation 2.** Load a DNA sequence from a string

Command: **Load 1** "ATGACTGATGAGAGATATTGA"  (load a string to DNA strand 1 (main strand))

**Operation 3.** Generate random DNA sequence of a BLOB
Command: **Generate f 1** (Generate random DNA of a female BLOB for DNA strand 1)
- Number of genes: 2-7
- Number of codons in a gene: 3-8 (including start and stop codons) 
- Codons in the genes are random codons (except for start and stop kodons)
- The first gene (gender gene) is not random. It contains 4 codons. 
  First codon is ATG. Fourth codon is TAG.
  Second and third codons of this gene determine the gender of the newborn.
  AAA or TTT = X
  GGG or CCC = Y

 XX        : female
 XY or YX  : male  

 ATG AAA TTT TAG -> female
 ATG TTT AAA TAG -> female
 ATG TTT TTT TAG -> female
 ATG TTT CCC TAG -> male
 ATG GGG AAA TAG -> male
 ATG GGG TTT TAG -> male

**Operation 4.** Check DNA gene structure

DNA strand  :  ATG ACT GAT GAG AGA TAT TGA
Gene structure is OK.

DNA strand  :  ATG ACT GAT GAG AGA TAT T
Codon structure error.

DNA strand  :  ATG ACT GAT GAG AGA TAT
Gene structure error.

DNA strand  :  ATG ATG ACT GAT GAG AGA TAT TGA
Gene structure error.

DNA strand  :  ATG TGA ATG TGA 
Gene structure is OK. (Not BLOB DNA, but OK)

**Operation 5.** Check DNA of BLOB organism

DNA strand  :  ATG AAA TTT TAG ATG ACT GAT GAG AGA TAT TGA
BLOB is OK.

DNA strand  :  ATG AAA TAG ATG ACT GAT GAG AGA TAT TGA
Gender error.

DNA strand  :  ATG AAA TAT TAG ATG ACT GAT GAG AGA TAT TGA
Gender error.

DNA strand  :  ATG AAA TTT TAG 
Number of genes error.

DNA strand  :  ATG ACT GAT GAG AGA TAT TGA
Gender error. Number of genes error.

DNA strand  :  ATG AAA TTT TAG ATG TGA
Number of codons error.

DNA strand  :  ATG AAA TTT TAG ATG AAA TTT TAG 
BLOB is OK.

**Operation 6.** Produce complement of a DNA sequence

DNA strand  :  ATG ACT GAT GAG AGA TAT TGA
Complement  :  TAC TGA CTA CTC TCT ATA ACT

**Operation 7.** Determine amino acids

DNA strand  :  ATG ACT GAT GAG AGA TAT TGA
Amino acids :  Met Thr Asp Glu Arg Tyr END

**Operation 8.** Delete codons (delete n codons, starting from mth codon) 

DNA strand (stage 1)  :  ATG ACT GAT GAG AGA TAT TGA
Delete 2 codons, starting from 3rd codon.
DNA strand (stage 2) :   ATG ACT AGA TAT TGA

**Operation 9.** Insert codons (insert a codon sequence, starting from mth codon) 

DNA strand (stage 1) :  ATG ACT AGA TAT TGA
Codon sequence       :  GAT GAG
Starting from        :  3
DNA strand (stage 2) :  ATG ACT GAT GAG AGA TAT TGA

**Operation 10.** Find codons (find a codon sequence, starting from mth codon) 

DNA strand      :  ATG ACT GAT GAG AGA TAT TGA
Codon sequence  :  GAT GAG
Starting from   :  2
Result          :  3

DNA strand      :  ATG ACT GAT GAG AGA TAT TGA
Codon sequence  :  GAT GAG
Starting from   :  4
Result          :  -1 (Not found)

**Operation 11.** Reverse codons (reverse n codons, starting from mth codon) 

DNA strand (stage 1)  :  ATG ACT GAT GAG AGA TAT TGA
Reverse 3 codons, starting from 2nd codon.
DNA strand (stage 2)  :  ATG GAG GAT ACT AGA TAT TGA


**Operation 12.** Find the number of genes in a DNA strand (BLOB or not)

DNA strand      :  ATG TAG ATG AAA TTT TAG ATG ACT GAT GAG AGA TAT TGA
Number of genes :  3

**Operation 13.** Find the shortest gene in a DNA strand

DNA strand      :  ATG TAG ATG AAA TTT TAG ATG ACT GAT GAG AGA TAT TGA
Shortest gene                :  ATG TAG
Number of codons in the gene :  2
Position of the gene         :  1

**Operation 14.** Find the longest gene in a DNA strand

DNA strand      :  ATG TAG ATG AAA TTT TAG ATG ACT GAT GAG AGA TAT TGA
Longest gene                 :  ATG ACT GAT GAG AGA TAT TGA
Number of codons in the gene :  7
Position of the gene         :  7

**Operation 15.** Find the most repeated n-nucleotide sequence in a DNA strand (STR - Short Tandem Repeat)

DNA strand      :  AGA GAT ACC GAG AGA TGT GAA TGT GAG AGA GAC ACA AGG AGA TAG
Enter number of nucletide :  4
Most repeated sequence    :  GAGA
Frequency                 :  5

**Operation 16.** Hydrogen bond statistics for a DNA strand
DNA strand  :  ACT GAT A  
Number of pairing with 2-hydrogen bonds: 5 
Number of pairing with 3-hydrogen bonds: 2
Number of hydrogen bonds: 16 

**Operation 17.** Simulate BLOB generations using DNA strand 1 and 2 (DNA strand 3 is for the newborn)
- Procreation needs 1 male BLOB and 1 female BLOB 
- For the newborn:
     - For the gender gene; second codon comes from BLOB1, third codon comes from BLOB2 
     - For other genes; 1 gene comes from BLOB1 (if any), and 1 gene comes from BLOB2 (if any).
- For the next generation; 
     - Newborn (BLOB3) is transferred to DNA strand 1 (BLOB1)
     - For DNA strand 2 (BLOB2); generate suitable gender random BLOB for procreation
     - Then procreate BLOB1 (DNA strand 1) and BLOB2 (DNA strand 2) again up to 10 generations

     (1).           _-->    (1).           _-->    (1).           _-->   
         }-> (3)  -'            }-> (3)  -'            }-> (3)  -'       
     (2)'                   (2)'                   (2)'                  

- For each newborn (BLOB3), check health condition:
- For our BLOB being; G-C bonds (3-hydrogen bonds) have some health risks. If 3 or more consecutive codons contain all 3-hydrogen bonds ("GGG CCC GCG" or "GGC CCG GCC CGC" ...), this condition is unhealthy, and those codons are called faulty codons.  
- If the ratio of faulty codons is greater than 10%, the newborn dies.

Generation 1:
BLOB1-XY : ATG AAA GGG TAG ATG AAA TAG
BLOB2-XX : ATG TTT TTT TAG ATG AGC TAG
BLOB3-XX : ATG AAA TTT TAG ATG AAA TAG
BLOB3 faulty codons ratio = 0/7 = 0%

Generation 2:
BLOB1-XX : ATG AAA TTT TAG ATG AAA TAG
BLOB2-YX : ATG CCC TTT TAG ATG AAA AAA TAG ATG GGG TAG ATG GGG GCG CCG TAG ATG CCC 
           GGG GCG CCG TAG
BLOB3-XX : ATG AAA TTT TAG ATG AAA TAG ATG GGG TAG ATG GGG GCG CCG TAG ATG CCC GGG
           GCG CCG TAG
BLOB3 faulty codons ratio = 7/21 = 33.3%
Newborn dies. Generations are over.

