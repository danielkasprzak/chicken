using System;
using System.IO;
using System.Threading;
using System.Net;

namespace chicken
{
    class Program
    {
        private static string version = "v0.4";

        private static string waterchicken = @"
                              __                  __                        
                             /\ \      __        /\ \                       
                          ___\ \ \___ /\_\    ___\ \ \/'\      __    ___    
                         /'___\ \  _ `\/\ \  /'___\ \ , <    /'__`\/' _ `\  
                        /\ \__/\ \ \ \ \ \ \/\ \__/\ \ \\`\ /\  __//\ \/\ \ 
                        \ \____\\ \_\ \_\ \_\ \____\\ \_\ \_\ \____\ \_\ \_\
                         \/____/ \/_/\/_/\/_/\/____/ \/_/\/_/\/____/\/_/\/_/
                                                        by goldblack                                          
                                                                            
        ";

        static void Main(string[] args)
        {
            Console.Title = "chicken - event scrambler by goldblack | " + version;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(waterchicken);

            string check = new WebClient()
            {
                Proxy = ((IWebProxy)null)
            }.DownloadString("https://pastebin.com/raw/ev4wfNqq");
            if (check.Contains(version))
            {
                Scrambler();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Version mismatch!");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }

        static void Scrambler()
        {
            string[] antiretard = {
            "gcPhone:_internalAddMessage", "gcPhone:tchat_channel", "esx_vehicleshop:setVehicleOwned", "esx_mafiajob:confiscatePlayerItem",
            "_chat:messageEntered", "lscustoms:payGarage", "vrp_slotmachine:server:2", "Banca:deposit", "bank:deposit", "esx_jobs:caution",
            "esx_fueldelivery:pay", "esx_carthief:pay", "esx_godirtyjob:pay", "esx_pizza:pay", "esx_ranger:pay", "esx_garbagejob:pay",
            "esx_truckerjob:pay", "AdminMenu:giveBank", "AdminMenu:giveCash", "esx_gopostaljob:pay", "esx_banksecurity:pay",
            "esx_slotmachine:sv:2", "esx:giveInventoryItem", "NB:recruterplayer", "esx_billing:sendBill", "esx_jailer:sendToJail",
            "esx_jail:sendToJail", "js:jailuser", "esx-qalle-jail:jailPlayer", "esx_dmvschool:pay", "LegacyFuel:PayFuel",
            "OG_cuffs:cuffCheckNearest", "CheckHandcuff", "cuffServer", "cuffGranted", "police:cuffGranted", "esx_handcuffs:cuffing",
            "esx_policejob:handcuff", "bank:withdraw", "dmv:success", "esx_skin:responseSaveSkin", "esx_dmvschool:addLicense",
            "esx_mechanicjob:startCraft", "esx_drugs:startHarvestWeed", "esx_drugs:startTransformWeed", "esx_drugs:startSellWeed",
            "esx_drugs:startHarvestCoke", "esx_drugs:startTransformCoke", "esx_drugs:startSellCoke", "esx_drugs:startHarvestMeth",
            "esx_drugs:startTransformMeth", "esx_drugs:startSellMeth", "esx_drugs:startHarvestOpium", "esx_drugs:startSellOpium",
            "esx_drugs:startTransformOpium", "esx_society:openBossMenu", "esx_jobs:caution", "esx_tankerjob:pay", "esx_vehicletrunk:giveDirty",
            "gambling:spend", "AdminMenu:giveDirtyMoney", "esx_moneywash:deposit", "esx_moneywash:withdraw", "mission:completed", "truckerJob:success",
            "99kr-burglary:addMoney", "esx_jailer:unjailTime", "esx_ambulancejob:revive", "esx:getSharedObject", "esx_society:getOnlinePlayers",
            "js:jailuser", "bank:transfer", "paycheck:bonus", "paycheck:salary", "HCheat:TempDisableDetection", "esx_drugs:pickedUpCannabis",
            "esx_drugs:processCannabis", "esx-qalle-hunting:reward", "esx-qalle-hunting:sell", "esx_mecanojob:onNPCJobCompleted",
            "BsCuff:Cuff696999", "veh_SR:CheckMoneyForVeh", "esx_carthief:alertcops", "mellotrainer:adminTempBan", "mellotrainer:adminKick",
            "esx_society:putVehicleInGarage", "DiscordBot:playerDied"
            };
        again:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(waterchicken);
            Console.WriteLine("> Popular events scrambler [1]");
            Console.WriteLine("> ESX scrambler [2]");
            Console.WriteLine("> Exit [3]\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(waterchicken);
                Console.WriteLine("> Put executable file in your resources dir.");
                Console.WriteLine("> Follow the instructions.");
                Console.WriteLine("> Program will scramble all events in .lua files known for him.\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Are you sure you want to continue? [Y/N]");
                Console.Write("> ");
                string yn = Console.ReadLine();
                if (yn == "Y" || yn == "y")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(waterchicken);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Write something unique and not too long: ");
                    string re = Console.ReadLine();
                    if (re.Length <= 10)
                    {
                        dothis(antiretard, re);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\"Not too long...\"");
                        Thread.Sleep(2000);
                        goto again;
                    }
                }
                else if (yn == "N" || yn == "n")
                {
                    Console.Clear();
                    goto again;
                }
                else
                    goto again;
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(waterchicken);
                Console.WriteLine("> Put executable file in your resources dir.");
                Console.WriteLine("> Follow the instructions.");
                Console.WriteLine("> Program will scramble all esx events in .lua files.\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Are you sure you want to continue? [Y/N]");
                Console.Write("> ");
                string yn = Console.ReadLine();
                if (yn == "Y" || yn == "y")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(waterchicken);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Write something unique and not too long: ");
                    string re = Console.ReadLine();
                    if (re.Length <= 8)
                    {
                        esxdothis(re);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\"Not too long...\"");
                        Thread.Sleep(2000);
                        goto again;
                    }
                }
                else if (yn == "N" || yn == "n")
                {
                    Console.Clear();
                    goto again;
                }
                else
                    goto again;
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("Have a nice day.");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else
                goto again;
        }

        public static void dothis(string[] antiretard, string replacement)
        {
            string[] antiretardFixed = {
            "gcPhone:_internal" + replacement + "AddMessage", "gcPhone:tcha" + replacement + "t_channel", "esx_vehicleshop:setVe" + replacement + "hicleOwned", "esx_mafiajob:confiscate" + replacement + "PlayerItem",
            "_chat:message" + replacement + "Entered", "lscustoms:pay" + replacement + "Garage", "vrp_slotmachine:ser" + replacement + "ver:2", "Banca:dep" + replacement + "osit", "bank:dep" + replacement + "osit", "esx_jobs:caut" + replacement + "ion",
            "esx_fuelde" + replacement + "livery:pay", "esx_carthi" + replacement + "ef:pay", "esx_godirt" + replacement + "yjob:pay", "esx_pizza:p" + replacement + "ay", "esx_rang" + replacement + "er:pay", "esx_garba" + replacement + "gejob:pay",
            "esx_trucke" + replacement + "rjob:pay", "AdminMe" + replacement + "nu:giveBank", "AdminMenu:give" + replacement + "Cash", "esx_gopos" + replacement + "taljob:pay", "esx_banksec" + replacement + "urity:pay",
            "esx_slotma" + replacement + "chine:sv:2", "esx:giveInv" + replacement + "entoryItem", "NB:recr" + replacement + "uterplayer", "esx_bill" + replacement + "ing:sendBill", "esx_jail" + replacement + "er:sendToJail",
            "esx_jail:send" + replacement + "ToJail", "js:ja" + replacement + "iluser", "esx-qall" + replacement + "e-jail:jailPlayer", "esx_dmv" + replacement + "school:pay", "Legac" + replacement + "yFuel:PayFuel",
            "OG_cuffs:cuffC" + replacement + "heckNearest", "CheckH" + replacement + "andcuff", "cuffSer" + replacement + "ver", "cuffG" + replacement + "ranted", "police:cuffGr" + replacement + "anted", "esx_ha" + replacement + "ndcuffs:cuffing",
            "esx_polic" + replacement + "ejob:handc" + replacement + "uff", "bank:with" + replacement + "draw", "dmv:suc" + replacement + "cess", "esx_skin:respon" + replacement + "seSaveSkin", "esx_dmv" + replacement + "school:addLicense",
            "esx_mechanicjob:star" + replacement + "tCraft", "esx_drugs:startHa" + replacement + "rvestWeed", "esx_drugs:start" + replacement + "TransformWeed", "esx_drug" + replacement + "s:startSellWeed",
            "esx_drugs:startHar" + replacement + "vestCoke", "esx_drugs:startT" + replacement + "ransformCoke", "esx_drugs:star" + replacement + "tSellCoke", "esx_drugs:sta" + replacement + "rtHarvestMeth",
            "esx_drugs:startTransf" + replacement + "ormMeth", "esx_drugs:start" + replacement + "SellMeth", "esx_drugs:startHa" + replacement + "rvestOpium", "esx_drugs:startSellOpi" + replacement + "um",
            "esx_drugs:startTra" + replacement + "nsformOpium", "esx_society:openBo" + replacement + "ssMenu", "esx_jobs:cau" + replacement + "tion", "esx_tank" + replacement + "erjob:pay", "esx_vehic" + replacement + "letrunk:giveDirty",
            "gambling:sp" + replacement + "end", "AdminMenu:giveD" + replacement + "irtyMoney", "esx_moneywash:depo" + replacement + "sit", "esx_mon" + replacement + "eywash:withdraw", "mission:com" + replacement + "pleted", "trucke" + replacement + "rJob:success",
            "99kr-burglary:addM" + replacement + "oney", "esx_jailer:unja" + replacement + "ilTime", "esx_ambul" + replacement + "ancejob:revive", "esx:getShar" + replacement + "edObject", "esx_society:getO" + replacement + "nlinePlayers",
            "js:jail" + replacement + "user", "bank:tran" + replacement + "sfer", "pay" + replacement + "check:bonus", "paycheck:sal" + replacement + "ary", "HCheat:Temp" + replacement + "DisableDetection", "esx_drugs:pickedUp" + replacement + "Cannabis",
            "esx_drugs:proce" + replacement + "ssCannabis", "esx-qalle-hun" + replacement + "ting:reward", "esx-qalle-hunting:s" + replacement + "ell", "esx_mec" + replacement + "anojob:onNPCJobCompleted",
            "BsCuff:Cuff" + replacement + "696999", "veh_SR:CheckMo" + replacement + "neyForVeh", "esx_carthief:ale" + replacement + "rtcops", "mellotrainer:adminTe" + replacement + "mpBan", "mello" + replacement + "trainer:adminKick",
            "esx_society:putVehi" + replacement + "cleInGarage", "DiscordBot:player" + replacement + "Died"
            };
            string rootfolder = AppDomain.CurrentDomain.BaseDirectory;
            string[] files = Directory.GetFiles(rootfolder, "*.lua", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                for (int i = 0; i < 87; i++)
                {
                    try
                    {
                        string text = File.ReadAllText(file);
                        text = text.Replace(antiretard[i], antiretardFixed[i]);
                        File.WriteAllText(file, text);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        public static void esxdothis(string replacement)
        {
            string rootfolder = AppDomain.CurrentDomain.BaseDirectory;
            string[] files = Directory.GetFiles(rootfolder, "*.lua", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                try
                {
                    string text = File.ReadAllText(file);
                    text = text.Replace("esx_", (replacement + "_"));
                    text = text.Replace("esx:", (replacement + ":"));
                    text = text.Replace("ESX.", (replacement.ToUpper() + "."));
                    File.WriteAllText(file, text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
