using System;
using System.Collections.Generic;
using System.Linq;

namespace FIRST_ASSIGNMENT_RR
{
    class AK_47
    {
        private int chancesAvailable = 2;
        private int bulletsAvailable = 0;
        private int[] bulletChamberSlots = new int[6];
        LinkedList<int> bulletSlots;
        private bool bWon = false;

        public bool GetPlayerWon()
        {
            return bWon;
        }

        private void SetPlayerWon(bool DidPlayerWon)
        {
            bWon = DidPlayerWon;
        }

        public int GetAvailableBullets()
        {
            return bulletsAvailable;
        }

        public int GetAvailableChances()
        {
            return chancesAvailable;
        }

        public void Load() // load function will load the bullet in chamber.
        {
            chancesAvailable = 2;
            bWon = false;
            if (CheckBulletInChambers())
            {
                // This will empty all the bullets from the chamber
                Array.Clear(bulletChamberSlots, 0, bulletChamberSlots.Length);
                loadBullets();
            }
            else
            {
                loadBullets();
            }
        }

        // Checks if there is any bullet in one of the chambers of revolver
        private bool CheckBulletInChambers()
        {
            foreach (int bullet in bulletChamberSlots)
            {
                if (bullet == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void loadBullets()
        {
            for (int i = 0; i < 6; i++)
            {
                if (i < 1 || i > 1)
                {
                    bulletChamberSlots[i] = 0;
                }
                else
                {
                    bulletChamberSlots[i] = i;
                }
                bulletsAvailable = bulletChamberSlots.Length;
            }
        }

        // Function that shuffles all the indexes in provided array
        private static void shuffle(int[] arr)
        {
            int n = arr.Length;
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                // Swaps indexes at random spots
                swap(arr, i, i + rand.Next(n - i));
            }

        }

        private static void swap(int[] arr, int a, int b)
        {
            // Swaps all indexes
            int randomInt = arr[a];
            arr[a] = arr[b];
            arr[b] = randomInt;
        }

        public void Spin() // spin function will spin the chamber.
        {
            // Moves the bullet to random slot
            shuffle(bulletChamberSlots);
            bulletSlots = new LinkedList<int>(bulletChamberSlots);
            // Changes he revolver bullet chamber and moves to next slot

            for (int i = 0; i < bulletChamberSlots.Length; i++)
            {
                Console.WriteLine(bulletSlots.ElementAt(i));
            }
            Console.ReadLine();
        }

        public void ShootAWAY() // Shoot Away function will allow player to shoot away or save the player.
        {
            // uses the same functionality but with bullet fired away and player doesn't lose any chance
            Shoot(true);
        }

        public void Shoot(bool bShotAway) // Shoot function will shoot the bullet.
        {
            --bulletsAvailable;
            if (!bShotAway)
            {
                if (chancesAvailable > 0 || bulletsAvailable > 0)
                {
                    if (bulletSlots.ElementAt(0) != 1)
                    {
                        bulletSlots.AddLast(bulletSlots.ElementAt(0));
                        bulletSlots.RemoveFirst();
                        if (chancesAvailable == 0)
                        {
                            // Player Lost
                            SetPlayerWon(false);
                        }
                    }
                    else
                    {
                        // Player Won
                        SetPlayerWon(true);
                    }
                }
                else
                {
                    Console.WriteLine("No Bullets or Chances Available!");
                    Console.ReadLine();
                }
                --chancesAvailable;
            }
            else
            {
                if (bulletChamberSlots[0] != 1)
                {
                    // Changes he revolver bullet chamber and moves to next slot
                    bulletSlots.AddLast(bulletSlots.ElementAt(0));
                    bulletSlots.RemoveFirst();
                }
                else
                {
                    // Player Lost because he fired the only bullet he had away
                    SetPlayerWon(false);
                }
            }
        }
    }
}
