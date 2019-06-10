# TicTacToe
*Bu uygulama Software Testing (Yazılım Sınama) dersi için socket programming (soket programlama) kulanılarak geliştirilmiştir.*

### AÇIKLAMA
#### Tic-Tac-Toe Oyunu
Aynı hat üzerinde X ve O sembollerini birleştirmek hedeflenmektedir. Aynı hat üzerinde X ya da O sembollerini ilk birleştiren oyunu kazanmaktadır. Tic-Tac-Toe oyunu 3×3 boyutunda bir kare alanında oynanmaktadır.
#### Amaç
Aynı hat üzerinde X ve O sembollerini rakipten önce birleştirip oyunu kazanmak.
#### Girdiler
<ul>
<li>gameMode of string
<li>P1.Name of string
<li>P1.Choice of string
<li>P2.Name of string
<li>P2.Choice of string
<li>serverIP of string
</ul><ol type="i">
<li>gameMode: Seçilen oyun modu
<li>P1.Name: Player1’in isim bilgisi
<li>P1.Choice: Player1’in sembol bilgisi(X-O)
<li>P2.Name: Player2’nin isim bilgisi
<li>P2.Choice: Player2’nin sembol bilgisi(X-O)
<li>serverIP: Socket oyun modunda bağlanılacak server’ın IP bilgisi
</ol>

#### Mantığı
İlk önce oyun modu seçilir, sonrasında bilgiler (isim ve sembol) doldurulur -bu alanların boş geçilmesi durumunda default değerler atanır(Player_1 etc.)- 
</br>Seçilen oyun moduna göre girilen bilgiler (isim ve sembol) dikkate alınarak tıklanılan alana tıklayan kişinin sembolü yazdırılır.
</br>Oyun modu “Computer” seçilmiş ise program otomatikmen oynar. Diğer oyun modları seçilmiş ise de oynama sırası diğer oyuncuya geçer.(“Timed” oyun modunda ise 5 saniye oynama süresi vardır, bu modda oyuncu süreyi bitirirse oyunu kaybetmiş olur.)
</br>Bu şekilde ilk aynı hat üzerinde X veya O sembollerini yerleştiren oyuncu -veya program- oyunu kazamış olur.

#### Test Case (X-O Yerleştirme Test Case)
<table style="width:100%">
  <tr>
    <td>Risk level</td>
    <td>Yüksek</td>
  </tr>
    <tr>
    <td>Purpose</td>
    <td>Oyunda belirlenen alana tıklanıldığında seçilen sembolün(X-O) doğru yerleştirilmesi.</td>
  </tr>
    <tr>
    <td>Inputs</td>
    <td>Oyun modunun seçilip bilgiler girildikten sonra start tuşu ile oyunun başlaması.</td>
  </tr>
    <tr>
    <td>Expected Outputs</td>
    <td>Oyunda belirlenen alana tıklanıldığında oyuncunun seçtiği sembolün çıkması.</td>
  </tr>
    <tr>
    <td>Pass Criterias</td>
    <td>Seçilen sembolün boş bir alana tıklanıldığında yerleştirilmesi. (BAŞARILI) </br>Seçilen sembolün dolu bir alana tıklanıldığında yerleştirilmemesi. (BAŞARILI) </br>Soket modu seçildiğinde sırası gelen oyuncu oynamadan diğer oyuncu belirlenen alana tıklaması durumunda sembolünü yerleştirmemesi ve uyarı vermesi. (BAŞARILI)</td>
  </tr>
    <tr>
    <td>Fail Criterias</td>
    <td>Seçilen sembol yerine belirlenen alana diğer sembolün yerleşmesi. (BAŞARISIZ) </br>Dolu bir alana tıklanıldığında o alandaki sembolün değişmesi. (BAŞARISIZ) </br>Süreli mod seçildiğinde herhangi bir oyuncunun süresi dolduğunda (5 saniye) oyunun devam etmesi. (BAŞARISIZ)</td>
  </tr>
    <tr>
    <td>Test Procedure</td>
    <td>Test kullanıcısı, yazılımı, desteklenen sistem ve cihazlarda çalıştırarak belirtilen girdilerle testi gerçekleştirmelidir. </br>Test işlemini tamamladıktan sonra test sonucunu Pass/Fail olarak belirtmelidir.</td>
  </tr>
    <tr>
    <td>Test Status</td>
    <td>Başarılı</td>
  </tr>
</table>
