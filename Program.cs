using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace populace
{
    internal class Person
    {
        public int age;
        public bool alz;
        public bool death;


        public Person(int age)
        {
            this.age = age;
            this.alz = false;
            this.death = false;
        }


    }

    class Program
    {
        private static void Main(string[] args)
        {
            //initial population
            #region init

            List<double> init = new List<double>();
            init.Add(5151598);
            init.Add(5248875);
            init.Add(5371211);
            init.Add(5406764);
            init.Add(5464960);
            init.Add(5359986);
            init.Add(5313324);
            init.Add(5238464);
            init.Add(5203165);
            init.Add(5158843);
            init.Add(5139792);
            init.Add(5190699);
            init.Add(5323846);
            init.Add(5278406);
            init.Add(5307753);
            init.Add(5367754);
            init.Add(5423865);
            init.Add(5440672);
            init.Add(5558826);
            init.Add(5716940);
            init.Add(5914570);
            init.Add(6066011);
            init.Add(6251482);
            init.Add(6280687);
            init.Add(6394618);
            init.Add(6367790);
            init.Add(6428468);
            init.Add(6480104);
            init.Add(6537404);
            init.Add(6580927);
            init.Add(6757120);
            init.Add(6830627);
            init.Add(6980010);
            init.Add(6939346);
            init.Add(6938877);
            init.Add(6970413);
            init.Add(7022642);
            init.Add(7073080);
            init.Add(7181345);
            init.Add(7125477);
            init.Add(7286731);
            init.Add(7414728);
            init.Add(7435589);
            init.Add(7540889);
            init.Add(7621377);
            init.Add(7659167);
            init.Add(7530450);
            init.Add(7553373);
            init.Add(7638871);
            init.Add(7487014);
            init.Add(7307250);
            init.Add(7257856);
            init.Add(7185886);
            init.Add(7087973);
            init.Add(6953566);
            init.Add(6889343);
            init.Add(6780831);
            init.Add(6677515);
            init.Add(6528333);
            init.Add(6364867);
            init.Add(6317852);
            init.Add(6169255);
            init.Add(6212348);
            init.Add(6146785);
            init.Add(6070156);
            init.Add(5899488);
            init.Add(5558534);
            init.Add(4684535);
            init.Add(4865470);
            init.Add(4729954);
            init.Add(4460040);
            init.Add(4470610);
            init.Add(4639885);
            init.Add(4444763);
            init.Add(4277950);
            init.Add(4076883);
            init.Add(3945545);
            init.Add(3762509);
            init.Add(3557384);
            init.Add(3254151);
            init.Add(3143143);
            init.Add(2954283);
            init.Add(2841498);
            init.Add(2521677);
            init.Add(2307119);
            init.Add(1533029);
            init.Add(1468163);
            init.Add(1391870);
            init.Add(1303043);
            init.Add(1200916);
            init.Add(1085324);
            init.Add(957028);
            init.Add(818092);
            init.Add(672235);
            init.Add(525043);
            init.Add(383856);
            init.Add(257090);
            init.Add(152821);
            init.Add(76702);
            init.Add(29783);
            init.Add(7409);

            #endregion

            //constants for mortality
            #region A
            List<double> A = new List<double>();


            A.Add(0.11937857031001);
            A.Add(0.0093079944013663);
            A.Add(0.00440449959062458);
            A.Add(0.0035535567385716);
            A.Add(0.00359350510002856);
            A.Add(0.00375745188230321);
            A.Add(0.00221780639153145);
            A.Add(0.00286270052990674);
            A.Add(0.00281153221967039);
            A.Add(0.00323145380631967);
            A.Add(0.00364120385631483);
            A.Add(0.0031744860324021);
            A.Add(0.00329309063403002);
            A.Add(0.00306850519014159);
            A.Add(0.00404036127375604);
            A.Add(0.00478391097866663);
            A.Add(0.00539599442130641);
            A.Add(0.00703754644477065);
            A.Add(0.0105782346616225);
            A.Add(0.0118934022358078);
            A.Add(0.0128514939644065);
            A.Add(0.0137930677055228);
            A.Add(0.0143686562152591);
            A.Add(0.0149587275264034);
            A.Add(0.0166803631349086);
            A.Add(0.0170807289904276);
            A.Add(0.0179510232285664);
            A.Add(0.0168240683673626);
            A.Add(0.0229356650949242);
            A.Add(0.0206997057318635);
            A.Add(0.024204715872532);
            A.Add(0.0231731860825536);
            A.Add(0.0268383640134971);
            A.Add(0.0247103718753662);
            A.Add(0.0285892002595903);
            A.Add(0.0270590699121371);
            A.Add(0.0296790306769979);
            A.Add(0.0349337353973782);
            A.Add(0.0394699506050252);
            A.Add(0.0405892053378285);
            A.Add(0.0450011489704399);
            A.Add(0.0497020750964498);
            A.Add(0.0517240867081373);
            A.Add(0.0539443402757713);
            A.Add(0.0554105448352424);
            A.Add(0.0595032369184772);
            A.Add(0.0628746413021234);
            A.Add(0.0728214261018189);
            A.Add(0.0805107325431299);
            A.Add(0.100442705739547);
            A.Add(0.119814506006491);
            A.Add(0.155535361538845);
            A.Add(0.193583516229326);
            A.Add(0.242203059058229);
            A.Add(0.331960890258714);
            A.Add(0.404779780070102);
            A.Add(0.51226184951975);
            A.Add(0.59756806009551);
            A.Add(0.633790433856666);
            A.Add(0.663439124958978);
            A.Add(0.67001625357051);
            A.Add(0.744956414305741);
            A.Add(0.731588121769485);
            A.Add(0.714317287977859);
            A.Add(0.692437989004299);
            A.Add(0.683644634874959);
            A.Add(0.679956665261453);
            A.Add(0.707319175705367);
            A.Add(0.685175470053812);
            A.Add(0.672667406755746);
            A.Add(0.734386975639801);
            A.Add(0.756719425022672);
            A.Add(0.82663285296228);
            A.Add(0.903897900599948);
            A.Add(0.970520022398259);
            A.Add(1.11737905514705);
            A.Add(1.26815353327741);
            A.Add(1.50893945264143);
            A.Add(1.74164221042519);
            A.Add(2.07406126868113);
            A.Add(2.44072025871262);
            A.Add(2.95792776778894);
            A.Add(3.57136239308633);
            A.Add(3.65334323394692);
            A.Add(5.2463596847574);

            #endregion
            #region B
            List<double> B = new List<double>();
            B.Add(22.468877101545);
            B.Add(21.3989344794243);
            B.Add(16.2112406339938);
            B.Add(17.1820540473614);
            B.Add(21.6852852100272);
            B.Add(25.8699170698859);
            B.Add(15.2492782375123);
            B.Add(22.3675683604358);
            B.Add(22.1101581470443);
            B.Add(26.6231390263105);
            B.Add(30.1522595241705);
            B.Add(24.4780617545222);
            B.Add(22.8464691606402);
            B.Add(17.8340050586748);
            B.Add(18.8551386580994);
            B.Add(17.935611183711);
            B.Add(15.0633266954337);
            B.Add(16.2512109395044);
            B.Add(19.4138956167434);
            B.Add(20.6184355426501);
            B.Add(21.1830863727163);
            B.Add(22.7016390779465);
            B.Add(23.4802351929234);
            B.Add(24.2797596004917);
            B.Add(27.3560735894248);
            B.Add(27.3388775886739);
            B.Add(28.1744095544324);
            B.Add(25.6056555674957);
            B.Add(35.6090421726376);
            B.Add(29.7478768084341);
            B.Add(33.6664810212744);
            B.Add(30.3338410724389);
            B.Add(33.682249461424);
            B.Add(28.3944527857694);
            B.Add(30.8237282897303);
            B.Add(26.3119636935535);
            B.Add(27.2671814698498);
            B.Add(29.761601952718);
            B.Add(30.7907481591487);
            B.Add(28.4373064069637);
            B.Add(28.7744564999597);
            B.Add(28.7151464323418);
            B.Add(26.9083754821886);
            B.Add(24.9624108348181);
            B.Add(22.8348628432399);
            B.Add(21.8302248117022);
            B.Add(20.5909880462377);
            B.Add(21.5292900605899);
            B.Add(21.4074786518817);
            B.Add(24.6735463238528);
            B.Add(26.8723392589602);
            B.Add(32.5105114081328);
            B.Add(37.7222407933862);
            B.Add(43.9844299388212);
            B.Add(56.6237172957141);
            B.Add(64.4135243845379);
            B.Add(76.3127124520563);
            B.Add(82.9994235938996);
            B.Add(81.8430652586138);
            B.Add(79.0456467200573);
            B.Add(73.3941749048556);
            B.Add(76.1892456865443);
            B.Add(69.1769123486888);
            B.Add(62.4987129780367);
            B.Add(55.5747161448001);
            B.Add(50.0494497266173);
            B.Add(45.7567789480623);
            B.Add(43.7059252813938);
            B.Add(38.334742321437);
            B.Add(34.0752155654603);
            B.Add(33.9180470194431);
            B.Add(31.5490572223734);
            B.Add(31.1186833233617);
            B.Add(30.8958670277881);
            B.Add(29.7746621461402);
            B.Add(31.0416332266201);
            B.Add(31.8096928125342);
            B.Add(34.3404158078829);
            B.Add(35.7620443383967);
            B.Add(38.4768557761064);
            B.Add(40.6548725849952);
            B.Add(44.4053857119729);
            B.Add(48.3591160007557);
            B.Add(43.5903113683117);
            B.Add(57.9082974780373);

            #endregion

            //mortality
            #region q
            List<double> q = new List<double>();
            for (int i = 0; i < 84; i++)
            {
                q.Add(0);
            }
            q.Add(0.0344537259665915);
            q.Add(0.0423128645186469);
            q.Add(0.0519647281547847);
            q.Add(0.0638182501449567);
            q.Add(0.0783756443299945);
            q.Add(0.0962536830795142);
            q.Add(0.118209828902496);
            q.Add(0.145174326863045);
            q.Add(0.178289617503146);
            q.Add(0.218958740131826);
            q.Add(0.268904777246886);
            q.Add(0.330243858649638);
            q.Add(0.405574818314485);
            q.Add(0.498089302624514);
            q.Add(0.611706995074337);
            q.Add(0.751241686683962);
            q.Add(0.730699178194735);

            #endregion
            #region qAlz
            List<double> qAlz = new List<double>();
            for (int i = 0; i < 65; i++)
            {
                qAlz.Add(0);
            }
            qAlz.Add(0.08207);
            qAlz.Add(0.08426);
            qAlz.Add(0.08656);
            qAlz.Add(0.08899);
            qAlz.Add(0.09157);
            qAlz.Add(0.09429);
            qAlz.Add(0.09719);
            qAlz.Add(0.10026);
            qAlz.Add(0.10354);
            qAlz.Add(0.10704);
            qAlz.Add(0.11079);
            qAlz.Add(0.1148);
            qAlz.Add(0.11912);
            qAlz.Add(0.12378);
            qAlz.Add(0.12881);
            qAlz.Add(0.13428);
            qAlz.Add(0.14022);
            qAlz.Add(0.14672);
            qAlz.Add(0.15385);
            qAlz.Add(0.1617);
            qAlz.Add(0.1704);
            qAlz.Add(0.18009);
            qAlz.Add(0.19095);
            qAlz.Add(0.20321);
            qAlz.Add(0.21714);
            qAlz.Add(0.240138725241667);
            qAlz.Add(0.275787509769321);
            qAlz.Add(0.316728384679399);
            qAlz.Add(0.363746964993195);
            qAlz.Add(0.417745490906002);
            qAlz.Add(0.479760140886842);
            qAlz.Add(0.5509809149216);
            qAlz.Add(0.632774469439402);
            qAlz.Add(0.726710342101943);
            qAlz.Add(0.834591069683629);
            qAlz.Add(0.958486776974965);
            #endregion

            //growth
            #region birth
            List<double> birth = new List<double>();

            birth.Add(0.0117839869311373);
            birth.Add(0.0118203598006761);
            birth.Add(0.0118647724864577);
            birth.Add(0.011909447991326);
            birth.Add(0.0119546687190995);
            birth.Add(0.0120005492184744);
            birth.Add(0.0120470349827905);
            birth.Add(0.0120939841894263);
            birth.Add(0.0121362610733949);
            birth.Add(0.0121614319346225);
            birth.Add(0.0121870853629254);
            birth.Add(0.01221285024698);
            birth.Add(0.012238556071075);
            birth.Add(0.0122640748277065);
            birth.Add(0.0122895011430767);
            birth.Add(0.0123149368386608);
            birth.Add(0.0123384113946628);
            birth.Add(0.0123595281044102);
            birth.Add(0.0123809026537772);
            birth.Add(0.012402210910525);
            birth.Add(0.0124232104646376);
            birth.Add(0.0124442554018205);
            birth.Add(0.0124654852168213);
            birth.Add(0.0124869742723292);
            birth.Add(0.012492417118669);
            birth.Add(0.0124902009832349);
            birth.Add(0.0124883797369725);
            birth.Add(0.0124868250703435);
            birth.Add(0.0124854205680558);
            birth.Add(0.0124840645744159);
            birth.Add(0.0124826106735828);
            birth.Add(0.012480921880404);
            birth.Add(0.0124825526880717);
            birth.Add(0.0124842413303122);
            birth.Add(0.0124856422653583);
            birth.Add(0.0124868798157974);
            birth.Add(0.0124880402847554);
            birth.Add(0.0124891400999825);
            birth.Add(0.0124902243726884);
            birth.Add(0.0124862759937121);
            birth.Add(0.012442093449163);
            birth.Add(0.0123982210382494);
            birth.Add(0.0123541850539519);
            birth.Add(0.0123099878336286);
            birth.Add(0.01226559462272);
            birth.Add(0.012220970677456);
            birth.Add(0.0121761250067195);
            birth.Add(0.012128938901867);
            birth.Add(0.0120773541136102);
            birth.Add(0.0120255376723177);
            birth.Add(0.0119734486922332);
            birth.Add(0.0119211252673686);
            birth.Add(0.011868623641108);
            birth.Add(0.0118159911464042);
            birth.Add(0.0117633079486696);
            birth.Add(0.0117243298482075);
            birth.Add(0.0116961895745427);
            birth.Add(0.0116679874819234);
            birth.Add(0.0116398268716624);
            birth.Add(0.0116116778259421);
            birth.Add(0.0115835144488504);
            birth.Add(0.0115552934686916);
            birth.Add(0.0115269995284775);
            birth.Add(0.0114858639006522);
            birth.Add(0.0114411508526665);
            birth.Add(0.0113964240603814);
            birth.Add(0.0113516567337098);
            birth.Add(0.0113068708478032);
            birth.Add(0.0112620851781915);
            birth.Add(0.0112172987850366);



            #endregion

            //prevalence rates
            #region r
            List<double> r = new List<double>();
            for (int i = 0; i < 65; i++)
            {
                r.Add(0);
            }

            r.Add(0.0157022663432993);
            r.Add(0.0176486820687054);
            r.Add(0.0198363708750637);
            r.Add(0.022295240401352);
            r.Add(0.0250589055673665);
            r.Add(0.0281651481181612);
            r.Add(0.0316564331344397);
            r.Add(0.0355804895679496);
            r.Add(0.0399909627379428);
            r.Add(0.0449481477104224);
            r.Add(0.0505198135847508);
            r.Add(0.0567821299572457);
            r.Add(0.0638207082273917);
            r.Add(0.0717317719801222);
            r.Add(0.0806234724482113);
            r.Add(0.0906173670353349);
            r.Add(0.101850081113062);
            r.Add(0.114475175807881);
            r.Add(0.128665247323068);
            r.Add(0.144614286476884);
            r.Add(0.162540330728912);
            r.Add(0.182688444945753);
            r.Add(0.205334071656097);
            r.Add(0.230786796587913);
            r.Add(0.259394580985818);
            r.Add(0.291548518544146);
            r.Add(0.327688182005048);
            r.Add(0.368307632507539);
            r.Add(0.413962173835764);
            r.Add(0.465275943918626);
            r.Add(0.522950447337568);
            r.Add(0.58777414552828);
            r.Add(0.660633235726432);
            r.Add(0.742523766093892);
            r.Add(0.834565252544267);
            r.Add(0.906736044508341);




            #endregion
            #region r0
            List<double> r0 = new List<double>();
            for (int i = 0; i < 65; i++)
            {
                r0.Add(0);
            }

            r0.Add(0.0159552172068661);
            r0.Add(0.0184753757614868);
            r0.Add(0.0231874962776455);
            r0.Add(0.0211187336337497);
            r0.Add(0.0253161353505763);
            r0.Add(0.0292800106707563);
            r0.Add(0.0308977879085852);
            r0.Add(0.0334601388980546);
            r0.Add(0.0406375912535719);
            r0.Add(0.0453345507960589);
            r0.Add(0.0512834566699608);
            r0.Add(0.056560300083005);
            r0.Add(0.0642573001954281);
            r0.Add(0.0725342664708111);
            r0.Add(0.0838439259754695);
            r0.Add(0.0887605883566226);
            r0.Add(0.101855631652079);
            r0.Add(0.111090873885535);
            r0.Add(0.134276525813179);
            r0.Add(0.144815745663314);
            r0.Add(0.162540330728701);
            r0.Add(0.182688428396112);
            r0.Add(0.205334022973212);
            r0.Add(0.230786743808032);
            r0.Add(0.259394549018232);
            r0.Add(0.29154841727133);
            r0.Add(0.327688159269559);
            r0.Add(0.368307572900632);
            r0.Add(0.413962357898421);
            r0.Add(0.465275633582828);
            r0.Add(0.522949859206967);
            r0.Add(0.587774661993635);
            r0.Add(0.660634573671731);
            r0.Add(0.742528110058696);
            r0.Add(0.834576956008969);
            r0.Add(0.938047152978934);

            #endregion

            #region Lists

            int newBorn = 0;

            //population
            List<double> n = new List<double>();

            //population with AD
            List<double> m = new List<double>();

            //incidence rate
            List<double> s = new List<double>();

            for (int j = 0; j < 101; j++)
            {
                n.Add(0);
                m.Add(0);
                s.Add(0);
            }
            #endregion

            //start of algorithm
            #region creation of initial population

            List<Person> population = new List<Person>();
            int initialAD = 0;

            for (int i = 0; i < init.Count; i++)
            {
                if (i > 64)
                {
                    initialAD = (int)(r0[i] * init[i]);
                }

                for (int j = 0; j < (int)(init[i]); j++)
                {
                    population.Add(new Person(i));
                    if (initialAD > 0)
                    {
                        population[population.Count - 1].alz = true;
                        initialAD--;
                    }


                }
            }

            #region N, M


            foreach (Person t in population)
            {
                n[t.age]++;
                if (t.alz)
                {
                    m[t.age]++;
                }
            }

            #endregion

            #endregion

            #region simulation

            //cycle for years
            for (int i = 0; i < 70; i++)
            {


                //cycle for agents
                Parallel.ForEach(population, agent =>
                {

                    double deathP;

                    if (agent.alz) deathP = qAlz[agent.age];
                    else
                    {
                        deathP = (agent.age < 85) ? (A[agent.age] / (i + B[agent.age])) : q[agent.age];
                        if (m[agent.age] > 0)
                        {
                            deathP = ((n[agent.age]) * deathP - (m[agent.age] * qAlz[agent.age])) / (n[agent.age] - m[agent.age]);
                        }
                    }

                    if (next() <= deathP || agent.age == 100) agent.death = true;

                    //age increment
                    agent.age++;
                });

                //removing dead agents
                population.RemoveAll(item => item.death == true);

                //calculation of growth
                newBorn = (int)(population.Count * birth[i]);

                for (int j = 0; j < newBorn; j++)
                {
                    population.Add(new Person(0));
                }

                #region N, M

                for (int j = 0; j < 101; j++)
                {
                    n[j] = 0;
                    m[j] = 0;
                }

                foreach (Person t in population)
                {
                    n[t.age]++;
                    if (t.alz)
                    {
                        m[t.age]++;
                    }
                }
                #endregion

                //calculation of Sx
                #region Sx
                for (int j = 65; j < 101; j++)
                {
                    s[j] = ((r[j] * n[j]) - m[j]) / (n[j] - m[j]);
                }
                #endregion

                Parallel.ForEach(population, agent =>
                {

                    if (agent.age > 64 && !agent.alz)
                    {
                        if (next() <= s[agent.age])
                        {
                            agent.alz = true;
                        }
                    }

                });
                #endregion

                Console.WriteLine("{0}_{1}_{2}", i + 1, population.Count, population.Count(item => item.alz == true));
            }


            Console.ReadLine();
        }

        #region randomFce

        private static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        private static byte[] result = new byte[8];

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        private static double next()
        {
            rng.GetBytes(result);
            return (double)BitConverter.ToUInt64(result, 0) / ulong.MaxValue;
        }

        #endregion
    }
}
