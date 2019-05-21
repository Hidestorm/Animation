using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public interface sortMethod
    {
        void sort(ref List<double> list);
    }

    public class InsertSort : sortMethod
    {
        public void sort(ref List<double> list)
        {
            // 从下标为1的元素开始选择合适的位置插入，因为下标为0的只有一个元素，默认是有序的
            for (int i = 1; i < list.Count(); i++)
            {
                double tmp = list[i];
                int j = i;
                while (j > 0 && tmp < list[j - 1])
                {
                    list[j] = list[j - 1];
                    j--;
                }

                // 存在比其小的数，插入
                if (j != i)
                {
                    list[j] = tmp;
                }
            }
        }
    }
}
