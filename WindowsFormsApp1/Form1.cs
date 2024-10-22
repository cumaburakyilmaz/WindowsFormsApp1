using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public decimal Toplam = 0;
        public Form1()
        {
            InitializeComponent();
        }
                
        private void button_Click(object sender, EventArgs e)
        {
            //Burdaki gedişkene sadece bu metod içinde ulaşmam gerektiginden local de tanımlamama gerek yok.
            decimal secilenParaninDegeri = 0;
            Button tıklanılanButon = (Button)sender;

            //Aşagıda hangi pictureboxa tıklanmış ise ona göre secilenParaninDegerini güncelliyoruz.
            switch (tıklanılanButon.Name)
            {
                case "btnLeonardo":
                    DigerleriniGizle("btnLeonardo", "pBLeonardo");
                    richTextBoxAciklama.Visible = true;
                    richTextBoxAciklama.Text = "Leonardo da Vinci “Mona Lisa” ; 1503” " +
                        " Listenin başında “Mona Lisa”nın olması eminiz ki kimseye sürpriz olmadı. Leonardo da Vinci’nin bu önemli başyapıtı, şu an dünyada en çok bilinen ve en çok ziyaret edilen sanat eseridir. “La Giaconda” olarak da bilinen eser, Floransalı varlıklı tüccar Francesco di Bartolomeo del Giocondo’nun \r\nKarısı olarak düşünülüyor. Tam olarak kimliği anlaşılamayan tablo, alternatif bir öneri olarak, Da vinci’nin annesini ve aslında kendi potresini de içeriyor.\r\n";
                    break;
                case "btnMichelangelo":
                    DigerleriniGizle("btnMichelangelo", "pBMichelaangelo");   
                    richTextBoxAciklama.Visible = true;
                    richTextBoxAciklama.Text = "Michelangelo, “The Creation of Adam” (Adem’in Yaratılışı); 1511" +
                        "\r\nMichelangelo’nun sanat hayatındaki en önemli eserlerinden biri olan “Adem’in Yaratılışı”, tarihte en çok tekrarlanan kutsal tablolardan biri olmuştur. Tanrı’nın gücüne olan inancına sadık kalarak onu yaşlı ama kaslı bir erkek olarak tasvir eden Michelangelo, bu tabloda, insan figürlerinden oluşan bulutun içindeki Tanrı’nın parmak ucuyla Adem’e ruh vermesiyle ilk insanın yaratılışını anlatarak aynı zamanda Tanrı’nın insan ve insanlıkla kurduğu bağı da temsil ediliyor. Bu ünlü eserin başrolündeki Adem ise sanat tarihindeki en ünlü nü çalışmalardan biri olarak biliniyor. 1508 ve 1512 yılları arasında yapılmış eser Vatikan’daki Sistina Şapeli’nde bulunuyor.\r\n";

                    break;
                case "btnSandrro":
                    DigerleriniGizle("btnSandrro", "pBSandro");
                    richTextBoxAciklama.Visible = true;
                    richTextBoxAciklama.Text = "Sandro Botticelli, “The Birth of Venus” (Venüs’ün Doğuşu); 1486" +
                        "Botticelli’nin ünlü eseri “Venüs’ün Doğuş’u”, etkili Floransa hanedanı Medici tarafından yaptırılmıştır. Mona Lisa’da yapıldığı gibi geleneksel ahşap panelleri kullanmak yerine tuval üzerine sulu boya ile resim yapmak, o dönemde popüler olan geleneksel malzemelerden bir kopma gösterir. Antik dünyayı referans alarak ortasında nü bulunan bu eser, Rönesans döneminin büyük bir hazinesidir. Yunan mitolojisinde Afrodit, Roma mitolojisinde ise Venüs olarak bilinen güzellik ve aşk tanrıçasının doğuşunu resmeden ressamın 1482 ila 1486 yılları arasında yaptığı bu ünlü eseri Floransa’daki Uffizi Galerisi’nde görebilirsiniz. \r\n";
                    break;
                case "btnJohannes":
                    DigerleriniGizle("btnJohannes", "pBJohannes"); 
                    richTextBoxAciklama.Visible = true;
                    richTextBoxAciklama.Text = "Johannes Vermeer, “Girl with a Pearl Earring”(İnci Küpeli Kız); 1665" +
                        " Çoğu insan tarafından “Kuzeyin Mona Lisa’sı” olarak düşünülen “İnci Küpeli Kız”, 17. yüzyılın Alman ressamı Johannes Vermeer tarafından resmedildi. Bakıldığında oldukça basit görünen bu portre aslında fazlasıyla gizemli! Başrolünde sadece inci bir küpe takan kız görülse de kızın kimliği etrafındaki spekülasyon, Vermeer’in metresi olmaktan onun 15 çocuğundan biri olmaya kadar uzanıyor.\r\n";
                    break;
                case "btnAndy":
                    DigerleriniGizle("btnAndy", "pBAndy");
                    richTextBoxAciklama.Visible = true;
                    richTextBoxAciklama.Text = "Andy Warhol, “Campbell’s Soup Cans” (Campbell’in Çorba Konserveleri); 1962 " +
                        " “Campbell’in Çorba Konserveleri”, şirket markası kullanarak Andy Warhol’un inanılmaz bir ün sağladığı bir dizi çalışmadan yalnızca bir tanesidir. Şablon kalıplar kullanılarak el ile yapılmış bu resmi dikkatli incelediğimizde bu konservelerin aralarındaki boşluklarının ya da görünümlerinin özdeş olmadığı gün yüzüne çıkıyor. Bir pop art sanatçısı olan Warhol’un 1962’de sunduğu 32 lezzetten birini temsil eden bu ünlü eseri, New York’taki The Museum of Modern Art’ta ziyaret edilebilir.\r\n";
                    break;
                case "btnPablo":
                    DigerleriniGizle("btnPablo", "pBPablo");

                    richTextBoxAciklama.Visible = true;
                    richTextBoxAciklama.Text = "Pablo Picasso, “Guernica”; 1937 " +
                        " Picasso’nun belirgin kübist stili içindeki politik bir protesto eseri olan “Guernica”, 1937’deki Paris Fuarı’nda öne çıkan parçalardan biriydi. Bu fuar için Picasso’dan bir çizim yapılması istenmiş ve Picasso, Kuzey İspanyol kasabası Guarnica’nın bombalanmasına kadar çizecek bir şey bulamamıştı. Bombalanmanın ardından ise çok kısa bir zaman içinde; Picasso’nun gri, siyah ve beyazdan oluşan geniş monokrom paletiyle yaratılan bu eser, olaylara bir tepki mahiyetindeydi. Hitler’in silahlı kuvvetleri tarafından gerçekleştirilen ve Franco hükümeti tarafından tasdik edilen bu saldırıyı anlatan Guernica tablosu, tarihteki en önemli isyan tablosu olarak Madrid’deki Kraliçe Sofia Ulusal Müzesi’nde bulunuyor.\r\n";
                    break;
            }
        }
              
        
        private void DigerleriniGizle(string buttonName, string pictureBoxName)
        {
            foreach (Control control in this.Controls)
            {
                // Button ve PictureBox isimleri hariç diğer kontrolleri gizle
                if (control is Button && control.Name != buttonName)
                {
                    control.Visible = false;
                }
                else if (control is PictureBox && control.Name != pictureBoxName)
                {
                    control.Visible = false;
                }
                else if (!(control is Button) && !(control is PictureBox))
                {
                    control.Visible = false;
                }
            }
                btnReset.Visible = true;
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
                richTextBoxAciklama.Visible = false;
            }
        
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void pBLeonardo_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxAciklama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
