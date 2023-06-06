using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumentum_Interview
{
    public  class Elavator
    {
        public List<int> track { get; set; }
        public List<int> storage { get; set; }
        public List<int> pipstop { get; set; }
        public static int number;
        public static string test;
        public static bool available = true;
        public static int memory = 0;
        public static int value = 0;
        public static  int[] arr;

        public static int[] memoir;

        public List<int> elevatorwentby = new List<int>();
       

        
        public async Task RequestAsync(storage1 holder)
        {
          
            available = false;
            String direction = "left";
            number =  await SCAN(holder, number, direction);
         

        }
        
        public static int size;
        static int disk_size = 200;


        /// <summary>
        /// /
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="head"></param>
        /// <param name="direction"></param>
        /// Alofgrithm to check the mostligc path if not read go to elvator floor 1
        public  async Task<int> SCAN(storage1 holder, int head, String direction)
        {

            if (elevatorwentby != null)
            {
                for (int i = 0; elevatorwentby.Count - 1 > 0; i++)
                {
                    holder.track.Remove(elevatorwentby[i]);
                }
            }
            arr = holder.track.ToArray();
            size = arr.Length;
            while (true)
            {
                try
                {
                    size = arr.Length;



                    int cur_track;
                    List<int> left = new List<int>();
                    List< int > right = new List<int>();
                    List<int> seek_sequence = new List<int>();


                    if (direction == "left")
                    {
                        left.Add(0);
                    }

                    else if (direction == "right")
                    {
                        right.Add(disk_size - 1);
                    }


                    for (int i = 0; i < size; i++)
                    {
                        if (arr[i] < head)
                            left.Add(arr[i]);
                        if (arr[i] > head)
                            right.Add(arr[i]);
                    }






                    left.Sort();
                    right.Sort();


                    int run = 2;
                    while (run-- > 0)
                    {
                        if (direction == "left")
                        {
                            for (int i = left.Count - 1; i >= 0; i--)
                            {
                                cur_track = left[i];


                                seek_sequence.Add(cur_track);


                                head = cur_track;
                            }
                            direction = "right";
                        }
                        else if (direction == "right")
                        {
                            for (int i = 0; i < right.Count; i++)
                            {
                                cur_track = right[i];

                                // appending current track to seek sequence
                                seek_sequence.Add(cur_track);
                                // accessed track is now new head
                                head = cur_track;
                            }
                            direction = "left";
                        }
                    }
                    for (int i = 0; i < seek_sequence.Count; i++)
                    {

                        if (seek_sequence[i] != 0)
                        {
                            await Task.Delay(4000);
                            number = seek_sequence[i];
                            holder.track.Remove(number);
                            elevatorwentby.Add(seek_sequence[i]);


                        }





                    }


                    return number;
                }
                catch
                {

                }
                await Task.Delay(1000);

            }

        }


    }
    }
