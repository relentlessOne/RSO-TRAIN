using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Trainz
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public CompositeType fetchData()
        {
            CompositeType CT = new CompositeType();
            //string apPath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            var filePath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath+"\\App_Data\\trains.csv";
            var data = File.ReadLines(filePath).Select(x => x.Split(',')).ToArray();

            var numOfRows = 0;

            foreach (var item in data)
            {
                numOfRows++;
            }
            numOfRows--;
            String[][] start = new String[numOfRows][];
            String[][] stop = new String[numOfRows][];
            var newRows = numOfRows + 1;
            String[] startTime = new String[newRows];
            String[] stopTime = new String[newRows];

            for (int ix = 0; ix < numOfRows; ix++)
            {
                start[ix] = new string[2];
                stop[ix] = new string[2];

            }

            var i = 0;
            foreach (var item in data)
            {
                if (item[0] != "Miejscowosc poczatkowa")
                {
                    start[i][0] = item[0];
                    start[i][1] = item[1];
                    stop[i][0] = item[2];
                    stop[i][1] = item[3];
                    startTime[i] = item[1];
                    stopTime[i] = item[3];
                    i++;
                }
            }
            startTime[newRows-1] = "Żaden";
            stopTime[newRows-1] = "Żaden";


            CT.Start = start;
            CT.Stop = stop;
            CT.StartTime = startTime;
            CT.StopTime = stopTime;



            return CT;
        }

        public bool checkIfStartCityExists(CompositeType CT,string clientData)
        {
            foreach(var el in CT.Start)
            {
                if(el[0] == clientData)
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkIfStopCityExists(CompositeType CT, string clientData)
        {
            foreach (var el in CT.Stop)
            {
                if (el[0] == clientData)
                {
                    return true;
                }
            }

            return false;
        }

        public string findConnection(CompositeType CT, string cityA, string cityB, string startDate, string stopDate)
        {

            if(!checkIfStopCityExists(CT,cityB) || !checkIfStartCityExists(CT, cityA))
            {
                return "";
            }


            string[] stopOptions = { "A", "B", "C", "D" };
            string[] startOptions = { "A", "B", "C" };

            stopOptions = stopOptions.Where(val => val != cityB).ToArray();
            stopOptions = stopOptions.Where(val => val != cityA).ToArray();

            string outData = "";


            for (var i = 0; i < CT.Start.Length; i++)
            {
                if (CT.Start[i][0] == cityA)
                {
                    if (CT.Stop[i][0] == cityB)
                    {
                        if (startDate == "Żaden" || stopDate == "Żaden")
                        {
                            outData += " \r\n";
                            outData += CT.Start[i][0] + ';' + CT.Start[i][1] + ';' + CT.Stop[i][0] + ';' + CT.Stop[i][1] + " \r\n";

                        }
                        else
                        {
                            if (DateTime.Parse(CT.Start[i][1]) >= DateTime.Parse(startDate) && DateTime.Parse(CT.Start[i][1]) <= DateTime.Parse(stopDate))
                            {
                                outData += " \r\n";
                                outData += CT.Start[i][0] + ';' + CT.Start[i][1] + ';' + CT.Stop[i][0] + ';' + CT.Stop[i][1] + " \r\n";
                            }

                        }

                    }

                    foreach (var option in stopOptions)
                    {
                        string[] stopDepp = stopOptions.Where(val => val != option).ToArray();

                        if (CT.Stop[i][0] == option)
                        {
                            for (var x = i; x < CT.Start.Length; x++)
                            {
                                var initI = i;
                                if (CT.Start[x][0] == option)
                                {
                                    if (CT.Stop[x][0] == cityB)
                                    {
                                        if (startDate == "Żaden" || stopDate == "Żaden")
                                        {
                                            outData += " \r\n";
                                            outData += CT.Start[initI][0] + ';' + CT.Start[initI][1] + ';' + CT.Stop[initI][0] + ';' + CT.Stop[initI][1] + " \r\n";
                                            outData += CT.Start[x][0] + ';' + CT.Start[x][1] + ';' + CT.Stop[x][0] + ';' + CT.Stop[x][1] + " \r\n";
                                        }
                                        else
                                        {
                                            if (DateTime.Parse(CT.Start[initI][1]) >= DateTime.Parse(startDate) && DateTime.Parse(CT.Start[initI][1]) <= DateTime.Parse(stopDate) && DateTime.Parse(CT.Stop[x][1]) <= DateTime.Parse(stopDate))
                                            {
                                                outData += " \r\n";
                                                outData += CT.Start[initI][0] + ';' + CT.Start[initI][1] + ';' + CT.Stop[initI][0] + ';' + CT.Stop[initI][1] + " \r\n";
                                                outData += CT.Start[x][0] + ';' + CT.Start[x][1] + ';' + CT.Stop[x][0] + ';' + CT.Stop[x][1] + " \r\n";
                                            }
                                        }
                                    }

                                    if (CT.Stop[x][0] == stopDepp[0])
                                    {
                                        for (var z = x; z < CT.Start.Length; z++)
                                        {
                                            var initX = x;
                                            if (CT.Start[z][0] == stopDepp[0])
                                            {
                                                if (CT.Stop[z][0] == cityB)
                                                {
                                                    if (startDate == "Żaden" || stopDate == "Żaden")
                                                    {
                                                        outData += " \r\n";
                                                        outData += CT.Start[initI][0] + ';' + CT.Start[initI][1] + ';' + CT.Stop[initI][0] + ';' + CT.Stop[initI][1] + " \r\n";
                                                        outData += CT.Start[initX][0] + ';' + CT.Start[initX][1] + ';' + CT.Stop[initX][0] + ';' + CT.Stop[initX][1] + " \r\n";
                                                        outData += CT.Start[z][0] + ';' + CT.Start[z][1] + ';' + CT.Stop[z][0] + ';' + CT.Stop[z][1] + " \r\n";
                                                    }
                                                    else
                                                    {

                                                        if (DateTime.Parse(CT.Start[initI][1]) >= DateTime.Parse(startDate) && DateTime.Parse(CT.Start[initI][1]) <= DateTime.Parse(stopDate) && DateTime.Parse(CT.Stop[z][1]) <= DateTime.Parse(stopDate))
                                                        {
                                                            outData += " \r\n";
                                                            outData += CT.Start[initI][0] + ';' + CT.Start[initI][1] + ';' + CT.Stop[initI][0] + ';' + CT.Stop[initI][1] + " \r\n";
                                                            outData += CT.Start[initX][0] + ';' + CT.Start[initX][1] + ';' + CT.Stop[initX][0] + ';' + CT.Stop[initX][1] + " \r\n";
                                                            outData += CT.Start[z][0] + ';' + CT.Start[z][1] + ';' + CT.Stop[z][0] + ';' + CT.Stop[z][1] + " \r\n";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                }
            }



            return outData;

        }

    }
}
