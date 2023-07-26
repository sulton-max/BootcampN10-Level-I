
// shart
//N12 - HT1

//- foydalanuvchi uchun User modelidan foydalaning ( F.I.SH. , to'liq ismi ) 
//- foydalanuvchi to'liq ismi uchun property va field e'lon qliing 
//- to'liq ismi propertysi get qilinganda fielddagi value ni return qilsin
//- ism, sharifi, familya set qliinganda to'liq ismi qayta hisoblansin
//- User modelini solishtirish logikasini qiymatlar hash code yordamida solishtiradigan qiling
//- User modelidan 2 ta bir xil qiymatli object yaratib, ularni tengligini tekshirib ekranga chiqaring

// logika
// user modelini yaratish ( FirstName, LastName, MiddleName, FullName )
// FullName - property va field bo'lishi kerak
// 

// code


var user = new User
{
    FirstName = "John",
    LastName = "Johnson",
    MiddleName = "Jones"
};

Console.WriteLine(user.FullName);

user.FirstName = "Ali";
user.CalculateFullName();

Console.WriteLine(user.FullName);

//hisoblanadigan operatsiyalar

// get - doimiy hisoblash
// set - tagidagi ma'lumotlari o'zgarganda hisoblash 

public class User
{
    public string _firstName;
    public string _lastName;
    public string _middleName;

    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            CalculateFullName();
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;



            CalculateFullName();
        }
    }

    public string MiddleName
    {
        get => _middleName;
        set
        {
            _middleName = value;
            CalculateFullName();
        }
    }

    public string _fullName;

    public void CalculateFullName()
    {
        _fullName = $"{FirstName} {LastName} {MiddleName}";
    }

    public string FullName
    {
        get => _fullName;
    }
}

//using System.Diagnostics;
//using System.Text;

//var test = new Test();

//var stopwatch = new Stopwatch();
//stopwatch.Start();

//for (var index = 0; index < 1_000; index++)
//{
//    var value = test.TestValue;
//}

//stopwatch.Stop();
//Console.WriteLine(stopwatch.ElapsedMilliseconds);

//public class Test
//{
//    public string _testValue = string.Empty;

//    public string TestValue
//    {
//        get
//        {
//            if(string.IsNullOrWhiteSpace(_testValue))
//            {
//                var initialText = new StringBuilder("Lorem ipsum dolor sit, amet consectetur adipisicing elit. Nulla, ad! Consectetur quas numquam id, aut repudiandae eligendi quis officia tempore dignissimos a dolor facere assumenda voluptatem maiores exercitationem? Impedit consequatur debitis unde iure nisi, ducimus illo dolore, ea quidem ipsam quod quia maiores, cum rerum reiciendis optio dolor! Aut quibusdam aliquam animi praesentium, ex ullam voluptatem at, ab dolorum doloribus delectus iste consequatur hic repudiandae omnis quos modi temporibus. Rem, suscipit? Distinctio, vero? Officiis consequuntur alias possimus ab magnam non earum explicabo officia sunt quaerat, suscipit labore maiores amet fuga assumenda. Quos doloremque, possimus at atque voluptates unde itaque exercitationem amet! Neque amet nisi tempore voluptates ducimus dignissimos. Fuga eveniet quidem inventore sed dolorum adipisci rerum commodi, at earum dolores doloremque dicta dignissimos, delectus ipsum a voluptatum et cum, totam consectetur facilis vitae provident aperiam. Maiores, quos a. Nam, amet eos. Pariatur amet similique accusantium minima hic doloribus officiis distinctio excepturi accusamus laboriosam iusto beatae soluta placeat illum labore, porro quae assumenda, voluptates eius! Hic maiores a, consequatur rem molestias nesciunt placeat. Porro quibusdam magnam maiores expedita atque quas iure alias provident placeat neque. Et laborum deserunt maiores ea quam inventore consequatur odio architecto blanditiis sapiente a laudantium, quisquam eveniet temporibus, voluptas voluptatem laboriosam quae aperiam vero est unde quia exercitationem odit? Alias magnam impedit labore eaque consequatur libero expedita neque cupiditate! Deleniti modi hic, id, libero dolor, voluptatum aut sint voluptatibus minima impedit molestias quia? Autem optio corrupti magni laudantium quasi, eius maxime asperiores architecto totam aliquid ab mollitia provident sint fugiat, illo, ipsa aut tenetur aperiam omnis quod? Vero iusto enim laborum, vitae eius nostrum ipsum beatae libero ipsam perspiciatis ullam molestiae, sed nulla atque illo ea saepe. Pariatur inventore reprehenderit amet sapiente debitis aliquam, doloribus aliquid! Iste doloribus, ut a qui adipisci enim deleniti natus dicta accusantium sunt alias non vero, dolorem in veniam consequuntur quaerat, dolorum voluptatibus facilis soluta! Voluptate ipsam laborum repellendus similique provident dolor rem nemo est possimus animi maiores quod quis maxime dolores dolorem doloribus mollitia fuga consequatur, reiciendis nam tempora expedita cum cupiditate in? Sunt provident aperiam repellendus inventore, maxime itaque enim consequatur distinctio, ipsum perferendis sed! Tempore officia voluptatum eum ipsum, quidem sint rerum cumque laboriosam architecto sed sunt eos molestiae, repellat similique placeat inventore laudantium corporis. Quas veniam amet illum quia accusamus, consequuntur deleniti voluptatem nihil earum eum beatae maiores neque officiis odio ex nostrum, et, in consectetur accusantium deserunt corporis? Illum eum et, ipsam magnam commodi nam blanditiis obcaecati sunt! Ex dolorem quas necessitatibus repudiandae fugiat laborum quaerat beatae. Commodi odit officia, ipsam facere ratione eos eius asperiores labore aliquam reiciendis similique tempora quis, incidunt aliquid totam. Doloribus sit sequi nulla illum dolorum asperiores amet quasi veritatis commodi? Sapiente provident inventore obcaecati totam eos labore eveniet aliquam accusamus ratione natus a quasi vel aperiam est reprehenderit explicabo et culpa fugit hic, veniam molestiae fugiat alias ducimus quo. Suscipit atque doloribus ullam, veritatis voluptatem ipsa odio accusantium officia sint repellendus necessitatibus incidunt mollitia. Vero, quis doloribus enim ad esse sint dolore non. Ducimus exercitationem atque dignissimos temporibus eveniet expedita est dolorum in voluptatem numquam fugiat, ad perferendis consequatur incidunt blanditiis libero eaque rem fugit enim corrupti recusandae! Perferendis, dolore doloremque. Minima repellendus vero iure dignissimos debitis. Dolores ducimus provident amet voluptas. Corrupti veritatis minus quod asperiores praesentium at itaque alias dolorum provident distinctio exercitationem dolorem possimus sint, maiores expedita, dicta eaque ullam impedit voluptate, odit quam quas? Expedita reprehenderit saepe, commodi sit alias natus adipisci repudiandae, doloremque quasi modi a nisi distinctio porro quas aliquid dolor dolorum repellat qui sequi quod facilis. Ut quidem nesciunt cupiditate sit ullam, corporis aliquid reprehenderit similique quaerat, laborum rem! Atque quod quas maxime quaerat perspiciatis voluptatibus cum asperiores quidem mollitia magnam vel iste, ratione quia tempore cumque, commodi velit, exercitationem eum repellendus suscipit! Eaque, sed maxime! Ipsam explicabo possimus, nihil dolorem quae officiis ea ex illo nisi odio aliquid inventore impedit quia, quasi illum non exercitationem sint expedita iusto. Incidunt quae omnis rem nesciunt asperiores odit consectetur voluptatem quidem accusamus non fugit eius molestiae dolorum ullam sit esse a perferendis eligendi laboriosam labore, delectus veritatis dolor! Dolorem quia unde ea officia non fugit sed nobis doloremque, voluptate harum iusto omnis hic quaerat laborum suscipit maiores consequatur tempora laudantium? Porro beatae excepturi voluptates eligendi nulla ut expedita nesciunt incidunt deserunt laborum nihil atque fuga et nisi nemo tenetur quis eaque quisquam hic adipisci officiis aut, quos asperiores consectetur! Rerum omnis laborum consequatur consequuntur dignissimos ex nisi rem debitis. Consequuntur vitae est fugit quo sequi architecto cum minus atque, eligendi minima explicabo animi, reprehenderit quas natus. Eveniet corrupti ipsa, veniam deleniti repellat possimus dignissimos doloremque repellendus dolores amet quaerat harum modi illo porro unde at vel aperiam consequuntur a hic, dolorum magni recusandae pariatur dicta! Enim magnam voluptates ab necessitatibus iure nesciunt dolorem natus recusandae? Vero, est rerum. Repellendus maxime modi hic doloremque, reiciendis pariatur quas ipsam vitae fugit aperiam. Ducimus aspernatur dolore sapiente eos sequi incidunt labore reprehenderit ea omnis doloribus, rem iusto cupiditate earum soluta reiciendis cumque aperiam eaque ratione quisquam at officiis aliquam. Maiores quasi eius et incidunt, culpa optio suscipit blanditiis fugit magni dicta sequi aut officia consectetur voluptatem, vel explicabo rerum, aliquid labore consequuntur fugiat nisi! Praesentium inventore sunt, nemo sapiente dolorum eaque doloribus cum velit veritatis omnis provident eligendi assumenda dolorem? Consequatur, quia laborum a sed fugit nobis esse cupiditate, cumque, nam deserunt consequuntur numquam earum. Distinctio, ullam molestias. Vero consequatur nulla, modi explicabo necessitatibus enim molestias quod nisi dignissimos, corporis quis repellendus vel totam culpa possimus odit repellat corrupti delectus autem eos architecto adipisci! Ipsam soluta, expedita assumenda velit reprehenderit magnam aliquam. Animi, reiciendis eos a, recusandae veritatis ab similique accusantium corporis ex nihil odio adipisci voluptatibus itaque culpa at impedit mollitia quae labore sequi consequuntur distinctio! Id rerum, maiores asperiores impedit assumenda voluptas omnis laborum provident veritatis libero? Debitis maiores in rerum doloribus ipsum animi velit labore similique? Eveniet ipsum deserunt temporibus ipsam laudantium impedit possimus labore distinctio illum eaque blanditiis autem, laboriosam corrupti eos asperiores animi voluptatibus!");
//                for (var index = 0; index < 10; index++)
//                    initialText.Append(initialText);

//                _testValue = initialText.ToString();    
//            }

//            return _testValue;
//        }
//    }
//}