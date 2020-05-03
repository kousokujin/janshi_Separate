using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace janshi_Separate
{
    static class janshi_gen
    {
        /// <summary>
        /// memberに入力された人たちでいい感じに4人または3人を作る。
        /// </summary>
        /// <param name="member">参加者</param>
        /// <returns>4人組リスト</returns>
        public static List<List<string>> separate_member(List<string> member,int seed=0)
        {
            if(member.Count < 4)
            {
                List<List<string>> output = new List<List<string>>();
                output.Add(member);
                return output;
            }
            int mods = member.Count % 4;
            int memberCount4 = member.Count - mods;

            Random rnd;
            if(seed == 0)
            {
                rnd = new Random();
            }
            else
            {
                rnd = new Random(seed);
            }

            List<string> randomMember = member.OrderBy(x => rnd.Next(member.Count)).ToList();

            List<List<string>> member4 = separateAnyMember(randomMember,4,rnd);
            List<string> member3 = member4.Last();
            if (member3.Count != 4){
                member4.Remove(member3);
                return generate3member(member4, member3, rnd);
            }
            else
            {
                return member4;
            }
            
        }

        static List<List<string>> generate3member(List<List<string>> member,List<string> modMembers,Random rnd)
        {
            List<List<string>> copy_member = new List<List<string>>(member);
            if ((modMembers.Count == 3) || (modMembers.Count==1 && member.Count ==1))
            {
                copy_member.Add(modMembers);
                return copy_member;
            }

            int selectGroup = 3 - modMembers.Count();
            List<int> selectIndex = new List<int>();

            for(int i = 0; i < selectGroup; i++)
            {
                int int_rand;
                do
                {
                    int_rand = rnd.Next(member.Count);
                    bool x = selectIndex.Contains(int_rand);
                } while (selectIndex.Contains(int_rand) == true);
                selectIndex.Add(int_rand);
            }

            List<string> sanma_menber = new List<string>();
            foreach(int x in selectIndex)
            {
                member[x].ForEach(item => sanma_menber.Add(item));
            }
            modMembers.ForEach(item => sanma_menber.Add(item));

            List<string>[] member_arr = copy_member.ToArray();
            selectIndex.ForEach(x => member_arr[x] = null);
            copy_member.Clear();
            foreach(List<string> s in member_arr)
            {
                if (s != null)
                {
                    copy_member.Add(s);
                }
            }
            
            List<List<string>> samma_group = separateAnyMember(sanma_menber, 3, rnd);
            samma_group.ForEach(x => copy_member.Add(x));

            return copy_member;

        }

        static List<List<string>> separateAnyMember(List<string> member,int group_count,Random rnd)
        {
            List<List<string>> outputMember = new List<List<string>>();

            string[] member_tmp = new string[group_count];
            foreach (var (item, index) in member.Select((item, index) => (item, index)))
            {
                member_tmp[index % group_count] = item;
                if ((index+1)%group_count == 0)
                {
                    outputMember.Add(member_tmp.ToList());
                }
            }

            if(member.Count % group_count != 0)
            {
                string[] member_tmp2 = new string[member.Count % group_count];
                for (int i = 0; i < member.Count % group_count; i++)
                {
                    member_tmp2[i] = member_tmp[i];
                }

                outputMember.Add(member_tmp2.ToList());
            }

            return outputMember;
        }
    }
}
