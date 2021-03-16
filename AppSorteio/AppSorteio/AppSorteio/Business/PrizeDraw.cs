using AppSorteio.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AppSorteio.Business
{
    public class PrizeDraw
    {
        private List<Person> LstPerson { get; set; } 
        public PrizeDraw()
        {
            LstPerson = new List<Person>();
            var file = new System.IO.StreamReader(@"Import/rd-http-adrianobinhara-com-br-lp-pre-lancamento-de-curso.csv");
            var line = "";
            var counter = 0;
            while ((line = file.ReadLine()) != null)
            {
                if (counter  == 0)
                {
                    counter++;
                    continue;
                }
                var splitLine = line.Split(',');
                LstPerson.Add(new Person()
                {
                    Index = counter,
                    Email = splitLine[0],
                    Name = splitLine[1],
                    UserName = splitLine[2]
                });
                counter++;
            }

            file.Close();
        }
        public Person PrizeDrawPerson()
        {
            var ran = new Random().Next(LstPerson.Max(m => m.Index));
            var result = LstPerson.Where(w => w.Index == ran).FirstOrDefault();
            return result;
        }
    }
}
