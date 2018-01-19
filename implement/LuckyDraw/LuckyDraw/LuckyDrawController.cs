using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    class LuckyDrawController
    {
        public bool IsDialing;
        public List<Person> PersonList;
        public List<Award> AwardList;
        public List<Person> AwardPersonList;
        LuckyDrawData luckyDrawData;

        public int CurrentAwardID;


        public LuckyDrawController()
        {
            IsDialing = false;

            //init award list
            AwardList = new List<Award>();
            AwardList.Add(new Award(0, "Giải 1"));
            AwardList.Add(new Award(1, "Giải 2"));
            AwardList.Add(new Award(2, "Giải 3"));
            this.CurrentAwardID = 0;
        }

        private int IncreaseIDAward()
        {
            int max = 0;
            if (AwardList.Count > 0)
            {
                max = AwardList.Max(e => e.ID);
            }

            return max + 1;
        }
        public int AddAward(string name)
        {
            string awardName = name.Trim();

            bool isExist = false;
            for (int i = 0; i < AwardList.Count; i++)
            {
                if (awardName == AwardList[i].Name.Trim())
                {
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                int newID = IncreaseIDAward();
                AwardList.Add(new Award(newID, name));
                return newID;
            }

            return -1;

        }
        public bool RemoveAward(int id)
        {
            var removeAward = AwardList.Find(e => e.ID == id);
            return AwardList.Remove(removeAward);
        }
        public bool EditAward(int id, string name)
        {
            string awardName = name.Trim();

            bool isExist = false;
            for (int i = 0; i < AwardList.Count; i++)
            {
                if (awardName == AwardList[i].Name.Trim())
                {
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                int editId = id;
                var editAward = AwardList.Find(t => t.ID == editId);
                if (editAward != null)
                {
                    editAward.Name = name;
                }
                return true;
            }

            return false;
        }
        public string GetCurAwardName()
        {
            var award = AwardList.Find(e => e.ID == CurrentAwardID);
            if (award != null)
                return award.Name;
            return "Giải thưởng";
        }

        public void StartLucky()
        {
           IsDialing = true;
        }
        public int Dial()
        {
            IsDialing = false;
            return Utilities.genRandomeNumber(1, 1000);
        }

        public void Stop()
        {
            IsDialing = false;
        }

        public void LoadDataBase(string path)
        {
            //new data

        }


        public void NextAward()
        {
            int index = AwardList.FindIndex(e => e.ID == CurrentAwardID);
            index++;
            if (AwardList.Count > 0)
            {
                index %= AwardList.Count;
                CurrentAwardID = AwardList[index].ID;
            }
            
        }

        public void PreAward()
        {
            int index = AwardList.FindIndex(e => e.ID == CurrentAwardID);
            if (--index < 0)
            {
                index = AwardList.Count - 1;
            }
            if (AwardList.Count > 0)
            {
                index %= AwardList.Count;
                CurrentAwardID = AwardList[index].ID;
            }

        }
    }
}
