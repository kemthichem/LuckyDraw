using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LuckyDraw
{
    class LuckyDrawController
    {
        const string INVALID_ID = "-1";

        public bool IsDialing;
        public List<Person> PersonList;
        public List<Award> AwardList;
        public List<Person> PersonArchivedList;
        LuckyDrawData luckyDrawData;

        public int CurrentAwardID;
        public string PersonArchivedID;

        public List<Person> PersonListBackup { get; set; }
        public bool HasDataToSave { get; set; }

        public LuckyDrawController()
        {
            IsDialing = false;
            HasDataToSave = false;

            //init award list
            AwardList = new List<Award>();
            AwardList.Add(new Award(0, "Giải 1"));
            AwardList.Add(new Award(1, "Giải 2"));
            AwardList.Add(new Award(2, "Giải 3"));
            this.CurrentAwardID = 0;
            PersonArchivedID = INVALID_ID;
            PersonArchivedList = new List<Person>();
            PersonList = new List<Person>();
            PersonListBackup = new List<Person>();
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

        internal List<string> GetCandidateNameList()
        {
            var names = PersonList.Select(p => p.Name);
            return names.ToList<string>();
        }

        public string GetCurAwardName()
        {
            var award = AwardList.Find(e => e.ID == CurrentAwardID);
            if (award != null)
            {                
                string str = award.Name + (award.Count > 0 ? " (" + award.Count.ToString() + ")" : "");
                return str;
            }
            return "Giải thưởng";
        }

        public bool StardDial()
        {
            if (PersonList.Count > 0)
            {
                IsDialing = true;
                return true;
            }
            return false;              
        }

        private void ArchiveForPerson(ref Person person)
        {
            var award = AwardList.Find(e => e.ID == CurrentAwardID);
            if (award != null)
            {
                person.AwardName = award.Name;
                award.PlusOne();
            }
        }
        public string StopDial()
        {
            IsDialing = false;
            if (PersonList.Count > 0)
            {
                int index = Utilities.genRandomeNumber(0, PersonList.Count);

                Person archivedPerson = PersonList[index];
                ArchiveForPerson(ref archivedPerson);
                PersonArchivedList.Add(PersonList[index]);
                PersonList.RemoveAt(index);

                PersonArchivedID = archivedPerson.Id;
                HasDataToSave = true;

                //int dialedNum = 0;
                //Int32.TryParse(PersonArchivedID, out dialedNum);
                return archivedPerson.Name;
            }

            return string.Empty;
        }
        public void LoadDBFunc(EndLoadDatabaseDl finishLoadDb, string path)
        {
            luckyDrawData = new LuckyDrawData(path);
            PersonList = luckyDrawData.GetListPersonFormDatabase();
            PersonListBackup.AddRange(PersonList);

            GetMaxNumberCharacterId();
            finishLoadDb();
        }
        public void LoadDataBase(EndLoadDatabaseDl finishLoadDb, string path)
        {
            Person p = new Person();
            Thread newThread = new Thread(() => LoadDBFunc(finishLoadDb, path));
            newThread.Start();
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

        public Person GetPersonArchived()
        {
            var p = PersonArchivedList.Find(e => e.Id == PersonArchivedID);
            return p;
        }

        internal bool IsAbleToBack()
        {
            if (HasDataToSave)
            {
                return false;
            }
            else
            {
                Reset();
                return true;
            }
        }

        internal void Reset()
        {
            PersonList.Clear();
            PersonList.AddRange(PersonListBackup);
            HasDataToSave = false;
            PersonArchivedList.Clear();

            for (int i = 0; i < AwardList.Count; i++)
            {
                AwardList[i].Count = 0;
            }
        }

        internal bool StartLucky()
        {
            if (PersonList.Count > 0)
            {
                return true;
            }

            return false;
        }        

        internal bool SavePersonArchived(string savePath)
        {
            if (luckyDrawData.SaveListPersonToDatabase(PersonArchivedList, savePath))
            {
                HasDataToSave = false;
                return true;
            }

            return false;
        }

        internal int GetMaxNumberCharacterId()
        {
            int max = 0;
            if (PersonList.Count > 0)
            {
                max = PersonList.Max(e => e.Id.Length);
            }

            return max;
        }

    }
}
