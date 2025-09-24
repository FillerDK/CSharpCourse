using System.Collections;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace L07_HTML_helpers.Infrastructure;

public class Utilities
{
    public static void SortSelectList(List<SelectListItem> selectList)
    {
        var textList = new ArrayList();
        var valueList = new ArrayList();

        foreach (var li in selectList)
        {
            textList.Add(li.Text);
        }
        textList.Sort();

        foreach (var item in textList)
        {
            var li = selectList.Find(x => x.Text.Contains(item.ToString()));
            valueList.Add(li.Value);
        }
        selectList.Clear();

        for (var i = 0; i < textList.Count; i++)
        {
            if (valueList[i].ToString() == selectList[i].ToString())
            {
                selectList.Add(new SelectListItem(textList[i].ToString(), valueList[i].ToString(), true));
            }
            else
            {
                selectList.Add(new SelectListItem(textList[i].ToString(), valueList[i].ToString()));
            }
        }
    }
}