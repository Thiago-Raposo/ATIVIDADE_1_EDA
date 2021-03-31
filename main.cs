using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
/*
fase 1: 0
fase 2: 0 , 1
fase 3: 1 , 0 , 0
fase 4: 1 , 0 , 1 , 0
fase 5: 0 , 0 , 1 , 1 , 0
fase 6: 0 , 1 , 1 , 0 , 1 , 1
fase 7: 1 , 1 , 0 , 1 , 1 , 0 , 1
fase 8: 0 , 1 , 0 , 1 , 0 , 1 , 0 , 1
fase 9: 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 1
fase 10: 1 , 1 , 0 , 1 , 0 , 0 , 0 , 1 , 0 , 1
*/

class MainClass
{
        static void Main(string[] args)
        {
          Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
            Console.WriteLine("\nQUE COMEÇEM OS JOGOOOOS!!! (hehe)\n\n");

            Console.WriteLine("#Fase 1\n");
            Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 1a)");
            int On=0, On2=0;

            var aux1 = Console.ReadLine();
            int fase1 = int.Parse(aux1);

            int contador = 1;

            if(fase1 == 0)
            {
                Console.WriteLine("Abriu!");
                Console.WriteLine("Parabéns você passou da fase 1!\n");
                Console.WriteLine("Ok ok, vamos combinar que essa foi fácil (hehe)");
                Console.WriteLine("Apartir de agora todos as fases terão uma porta a mais depois de cada nível.");
                Console.WriteLine("OBS: se você perder terá que voltar do início :)\n");

                for(int i = 0; i<2; i++)
                {
                    Console.WriteLine("\n#Fase 2\n");

                    if(i==0){
                    
                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 2a)");
                    var aux2aa = Console.ReadLine();
                    int fase2aa = int.Parse(aux2aa);

                    switch(fase2aa){
                    case 0:
                    
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    contador = contador - 1;
                   
                    int[] vet2a = new int[1000];
                    int[] vet2b = new int[1000];
                    Console.WriteLine("Calma... você ainda tem uma chance, se tiver sorte (hehe)");
                    for(int j = 0; j<1000; j++)
                    {
                    var numAleat2aa = new Random((int)DateTime.Now.Ticks);
                    vet2b[j] = numAleat2aa.Next(-10,10);
                    On2 +=1; 

                    if(vet2b[j]>=1){
                      vet2a[j]=1;
                    }
                    else{
                      vet2a[j]=0;
                    }

                    if(j==999){
                      Console.WriteLine("O número sortiado é... " + vet2a[999]);

                    switch (vet2a[999])
                    {

                        case 0:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 1:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts1a = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime1a = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts1a.Hours, ts1a.Minutes, ts1a.Seconds,
            ts1a.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime1a);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    break;
                    }
                    }

                    if(i==1){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 2b)");
                    var aux2bb = Console.ReadLine();
                    int fase2bb = int.Parse(aux2bb);

                    switch(fase2bb){
                    case 1:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts1b = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime1b = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts1b.Hours, ts1b.Minutes, ts1b.Seconds,
            ts1b.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime1b);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet2c = new int[2000];
                    int[] vet2d = new int[2000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<2000; j++)
                    {
                    var numAleat2bb = new Random((int)DateTime.Now.Ticks);
                    vet2d[j] = numAleat2bb.Next(-10,10);
                    On2 += 1;
                    
                    if(vet2d[j]>=1){
                      vet2c[j]=1;
                    }
                    else{
                      vet2c[j]=0;
                    }

                    if(j==1999){
                      Console.WriteLine("O número sortiado é... " + vet2c[1999]);

                    switch (vet2c[1999])
                    {

                        case 1:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 0:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts1c = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime1c = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts1c.Hours, ts1c.Minutes, ts1c.Seconds,
            ts1c.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime1c);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    } 
                    
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts1 = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts1.Hours, ts1.Minutes, ts1.Seconds,
            ts1.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime1);
     
                }

                contador = 1;

                for(int i = 0; i<3; i++)
                {
                    Console.WriteLine("\n#Fase 3\n");

                    if(i==0){
                    
                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 3a)");
                    var aux3aa = Console.ReadLine();
                    int fase3aa = int.Parse(aux3aa);

                    switch(fase3aa){
                    case 1:
                    
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    contador = contador - 1;
                   
                    int[] vet3a = new int[3000];
                    int[] vet3b = new int[3000];
                    Console.WriteLine("Calma... você ainda tem uma chance, se tiver sorte (hehe)");
                    for(int j = 0; j<3000; j++)
                    {
                    var numAleat3aa = new Random((int)DateTime.Now.Ticks);
                    vet3b[j] = numAleat3aa.Next(-10,10);
                    On2 += 1;

                    if(vet3b[j]>=1){
                      vet3a[j]=1;
                    }
                    else{
                      vet3a[j]=0;
                    }

                    if(j==2999){
                      Console.WriteLine("O número sortiado é... " + vet3a[2999]);

                    switch (vet3a[2999])
                    {

                        case 1:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 0:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts2a = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime2a = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts2a.Hours, ts2a.Minutes, ts2a.Seconds,
            ts2a.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime2a);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    break;
                    }
                    }

                    if(i==1){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 3b)");
                    var aux3bb = Console.ReadLine();
                    int fase3bb = int.Parse(aux3bb);

                    switch(fase3bb){
                    case 0:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts2b = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime2b = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts2b.Hours, ts2b.Minutes, ts2b.Seconds,
            ts2b.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime2b);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet3c = new int[4000];
                    int[] vet3d = new int[4000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<4000; j++)
                    {
                    var numAleat3bb = new Random((int)DateTime.Now.Ticks);
                    vet3d[j] = numAleat3bb.Next(-10,10);
                    On2 += 1;
                    
                    if(vet3d[j]>=1){
                      vet3c[j]=1;
                    }
                    else{
                      vet3c[j]=0;
                    }

                    if(j==3999){
                      Console.WriteLine("O número sortiado é... " + vet3c[3999]);

                    switch (vet3c[3999])
                    {

                        case 0:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 1:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts2c = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime2c = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts2c.Hours, ts2c.Minutes, ts2c.Seconds,
            ts2c.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime2c);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    }

                    if(i==2){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 3c)");
                    var aux3cc = Console.ReadLine();
                    int fase3cc = int.Parse(aux3cc);

                    switch(fase3cc){
                    case 0:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts2d = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime2d = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts2d.Hours, ts2d.Minutes, ts2d.Seconds,
            ts2d.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime2d);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet3e = new int[5000];
                    int[] vet3f = new int[5000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<5000; j++)
                    {
                    var numAleat3cc = new Random((int)DateTime.Now.Ticks);
                    vet3f[j] = numAleat3cc.Next(-10,10);
                    On2 += 1;
                    
                    if(vet3f[j]>=1){
                      vet3e[j]=1;
                    }
                    else{
                      vet3e[j]=0;
                    }

                    if(j==4999){
                      Console.WriteLine("O número sortiado é... " + vet3e[4999]);

                    switch (vet3e[4999])
                    {

                        case 0:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 1:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts2e = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime2e = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts2e.Hours, ts2e.Minutes, ts2e.Seconds,
            ts2e.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime2e);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    } 
                    
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts2 = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts2.Hours, ts2.Minutes, ts2.Seconds,
            ts2.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime2);
                            
                }

                contador = 1;

                for(int i = 0; i<4; i++)
                {
                    Console.WriteLine("\n#Fase 4\n");

                    if(i==0){
                    
                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 4a)");
                    var aux4aa = Console.ReadLine();
                    int fase4aa = int.Parse(aux4aa);

                    switch(fase4aa){
                    case 1:
                    
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    contador = contador - 1;
                   
                    int[] vet4a = new int[1000];
                    int[] vet4b = new int[1000];
                    Console.WriteLine("Calma... você ainda tem uma chance, se tiver sorte (hehe)");
                    for(int j = 0; j<1000; j++)
                    {
                    var numAleat4aa = new Random((int)DateTime.Now.Ticks);
                    vet4b[j] = numAleat4aa.Next(-10,10);
                    On2 += 1;

                    if(vet4b[j]>=1){
                      vet4a[j]=1;
                    }
                    else{
                      vet4a[j]=0;
                    }

                    if(j==999){
                      Console.WriteLine("O número sortiado é... " + vet4a[999]);

                    switch (vet4a[999])
                    {

                        case 1:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 0:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts3a = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime3a = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts3a.Hours, ts3a.Minutes, ts3a.Seconds,
            ts3a.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime3a);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    break;
                    }
                    }

                    if(i==1){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 4b)");
                    var aux4bb = Console.ReadLine();
                    int fase4bb = int.Parse(aux4bb);

                    switch(fase4bb){
                    case 0:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts3b = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime3b = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts3b.Hours, ts3b.Minutes, ts3b.Seconds,
            ts3b.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime3b);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet4c = new int[2000];
                    int[] vet4d = new int[2000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<2000; j++)
                    {
                    var numAleat4bb = new Random((int)DateTime.Now.Ticks);
                    vet4d[j] = numAleat4bb.Next(-10,10);
                    On2 += 1;
                    
                    if(vet4d[j]>=1){
                      vet4c[j]=1;
                    }
                    else{
                      vet4c[j]=0;
                    }

                    if(j==1999){
                      Console.WriteLine("O número sortiado é... " + vet4c[1999]);

                    switch (vet4c[1999])
                    {

                        case 0:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 1:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts3c = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime3c = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts3c.Hours, ts3c.Minutes, ts3c.Seconds,
            ts3c.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime3c);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    }

                    if(i==2){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 4c)");
                    var aux4cc = Console.ReadLine();
                    int fase4cc = int.Parse(aux4cc);

                    switch(fase4cc){
                    case 1:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts3d = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime3d = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts3d.Hours, ts3d.Minutes, ts3d.Seconds,
            ts3d.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime3d);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet4e = new int[3000];
                    int[] vet4f = new int[3000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<3000; j++)
                    {
                    var numAleat4cc = new Random((int)DateTime.Now.Ticks);
                    vet4f[j] = numAleat4cc.Next(-10,10);
                    On2 += 1;
                    
                    if(vet4f[j]>=1){
                      vet4e[j]=1;
                    }
                    else{
                      vet4e[j]=0;
                    }

                    if(j==2999){
                      Console.WriteLine("O número sortiado é... " + vet4e[2999]);

                    switch (vet4e[2999])
                    {

                        case 1:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 0:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts3e = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime3e = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts3e.Hours, ts3e.Minutes, ts3e.Seconds,
            ts3e.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime3e);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    }


                    if(i==3){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 4d)");
                    var aux4dd = Console.ReadLine();
                    int fase4dd = int.Parse(aux4dd);

                    switch(fase4dd){
                    case 0:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts3f = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime3f = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts3f.Hours, ts3f.Minutes, ts3f.Seconds,
            ts3f.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime3f);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet4g = new int[4000];
                    int[] vet4h = new int[4000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<4000; j++)
                    {
                    var numAleat4dd = new Random((int)DateTime.Now.Ticks);
                    vet4h[j] = numAleat4dd.Next(-10,10);
                    On2 += 1;
                    
                    if(vet4h[j]>=1){
                      vet4g[j]=1;
                    }
                    else{
                      vet4g[j]=0;
                    }

                    if(j==3999){
                      Console.WriteLine("O número sortiado é... " + vet4g[3999]);

                    switch (vet4g[3999])
                    {

                        case 0:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 1:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts3g = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime3g = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts3g.Hours, ts3g.Minutes, ts3g.Seconds,
            ts3g.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime3g);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    } 
                    
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts3 = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime3 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts3.Hours, ts3.Minutes, ts3.Seconds,
            ts3.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime3);
                              
                }

                contador = 1;

                for(int i = 0; i<5; i++)
                {
                    Console.WriteLine("\n#Fase 5\n");

                    if(i==0){
                    
                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 5a)");
                    var aux5aa = Console.ReadLine();
                    int fase5aa = int.Parse(aux5aa);

                    switch(fase5aa){
                    case 0:
                    
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    contador = contador - 1;
                   
                    int[] vet5a = new int[5000];
                    int[] vet5b = new int[5000];
                    Console.WriteLine("Calma... você ainda tem uma chance, se tiver sorte (hehe)");
                    for(int j = 0; j<5000; j++)
                    {
                    var numAleat5aa = new Random((int)DateTime.Now.Ticks);
                    vet5b[j] = numAleat5aa.Next(-10,10);
                    On2 += 1;

                    if(vet5b[j]>=1){
                      vet5a[j]=1;
                    }
                    else{
                      vet5a[j]=0;
                    }

                    if(j==4999){
                      Console.WriteLine("O número sortiado é... " + vet5a[4999]);

                    switch (vet5a[4999])
                    {

                        case 0:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 1:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4a = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4a = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4a.Hours, ts4a.Minutes, ts4a.Seconds,
            ts4a.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4a);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    break;
                    }
                    }

                    if(i==1){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 5b)");
                    var aux5bb = Console.ReadLine();
                    int fase5bb = int.Parse(aux5bb);

                    switch(fase5bb){
                    case 0:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4b = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4b = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4b.Hours, ts4b.Minutes, ts4b.Seconds,
            ts4b.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4b);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet5c = new int[1000];
                    int[] vet5d = new int[1000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<1000; j++)
                    {
                    var numAleat5bb = new Random((int)DateTime.Now.Ticks);
                    vet5d[j] = numAleat5bb.Next(-10,10);
                    On2 += 1;
                    
                    if(vet5d[j]>=1){
                      vet5c[j]=1;
                    }
                    else{
                      vet5c[j]=0;
                    }

                    if(j==999){
                      Console.WriteLine("O número sortiado é... " + vet5c[999]);

                    switch (vet5c[999])
                    {

                        case 0:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 1:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4c = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4c = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4c.Hours, ts4c.Minutes, ts4c.Seconds,
            ts4c.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4c);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    }

                    if(i==2){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 5c)");
                    var aux5cc = Console.ReadLine();
                    int fase5cc = int.Parse(aux5cc);

                    switch(fase5cc){
                    case 1:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4d = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4d = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4d.Hours, ts4d.Minutes, ts4d.Seconds,
            ts4d.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4d);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet5e = new int[2000];
                    int[] vet5f = new int[2000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<2000; j++)
                    {
                    var numAleat5cc = new Random((int)DateTime.Now.Ticks);
                    vet5f[j] = numAleat5cc.Next(-10,10);
                    On2 += 1;
                    
                    if(vet5f[j]>=1){
                      vet5e[j]=1;
                    }
                    else{
                      vet5e[j]=0;
                    }

                    if(j==1999){
                      Console.WriteLine("O número sortiado é... " + vet5e[1999]);

                    switch (vet5e[1999])
                    {

                        case 1:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 0:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4e = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4e = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4e.Hours, ts4e.Minutes, ts4e.Seconds,
            ts4e.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4e);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    }


                    if(i==3){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 5d)");
                    var aux5dd = Console.ReadLine();
                    int fase5dd = int.Parse(aux5dd);

                    switch(fase5dd){
                    case 1:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4f = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4f = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4f.Hours, ts4f.Minutes, ts4f.Seconds,
            ts4f.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4f);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet5g = new int[3000];
                    int[] vet5h = new int[3000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<3000; j++)
                    {
                    var numAleat5dd = new Random((int)DateTime.Now.Ticks);
                    vet5h[j] = numAleat5dd.Next(-10,10);
                    On2 += 1;
                    
                    if(vet5h[j]>=1){
                      vet5g[j]=1;
                    }
                    else{
                      vet5g[j]=0;
                    }

                    if(j==2999){
                      Console.WriteLine("O número sortiado é... " + vet5g[2999]);

                    switch (vet5g[2999])
                    {

                        case 1:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 0:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4g = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4g = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4g.Hours, ts4g.Minutes, ts4g.Seconds,
            ts4g.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4g);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    }

                    if(i==4){

                    Console.WriteLine("Digite 0 ou 1 para abrir a porta correta (porta 5e)");
                    var aux5ee = Console.ReadLine();
                    int fase5ee = int.Parse(aux5ee);

                    switch(fase5ee){
                    case 0:
                    Console.WriteLine("Abriu!");
                    On += 1;
                    break;

                    default: 
                    if (contador == 0){
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4h = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4h = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4h.Hours, ts4h.Minutes, ts4h.Seconds,
            ts4h.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4h);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                    }
                    else{
                    contador = contador - 1;
                    
                    int[] vet5i = new int[4000];
                    int[] vet5j = new int[4000];
                    Console.WriteLine("Calma... você ainda tem uma chance nesta fase, se tiver sorte (hehe)");
                    for(int j = 0; j<4000; j++)
                    {
                    var numAleat5ee = new Random((int)DateTime.Now.Ticks);
                    vet5j[j] = numAleat5ee.Next(-10,10);
                    On2 += 1;
                    
                    if(vet5j[j]>=1){
                      vet5i[j]=1;
                    }
                    else{
                      vet5i[j]=0;
                    }

                    if(j==3999){
                      Console.WriteLine("O número sortiado é... " + vet5i[3999]);

                    switch (vet5i[3999])
                    {

                        case 0:
                        Console.WriteLine("Parabéns você tem sorte, mais cuidado na próxima");
                        break;

                        case 1:
                        Console.WriteLine("infelizmente você perdeu :)");
                        
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4i = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4i = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4i.Hours, ts4i.Minutes, ts4i.Seconds,
            ts4i.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4i);
                        Console.WriteLine("Total de funções executadas: {0}",On + On2);
                        Console.WriteLine("O(n): {0}", On);
                        Console.WriteLine("O(n2): {0}", On2);
                        Environment.Exit(0);
                        break;
                    }
                    }
                    }

                    }
                    break;               
                    }  
                    }  
                    
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts4 = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime4 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts4.Hours, ts4.Minutes, ts4.Seconds,
            ts4.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime4);
                    
                }
           Console.WriteLine(On);
           Console.WriteLine(On2);
          }
          else{
            Console.WriteLine("infelizmente você perdeu :)");
          }
          stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
        }
      } 