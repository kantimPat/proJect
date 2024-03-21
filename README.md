# ความเป็นมาของโปรแกรม
### โปรแกรมนี้สร้างขึ้นเพื่อใช้สำหรับการขายรองเท้าออนไลน์ 
# วัตถุประสงค์ของโปรแกรม
### โปรแกรมนี้จัดทำขึ้นไว้สำหรับผู้ที่สนใจที่จะซื้อรองเท้า หรือกำลังหาข้อมูลรองเท้าและราคา หรือถ้าหากสนใจก็สามารถสั่งซื้อในตัวโปรแกรมนี้ได้ เพราะมีการคำนวณราคารวมของสินค้าแสดงให้ดู
# ชื่อของผู้พัฒนาโปรแกรม
### นางสาวกันทิมา พิมรัตน์ 663450033-9
```mermaid
classDiagram
    From1 <|-- Products
    Products :+public string Chicago
    Products :+public string Indigo
    Products :+public string Cacao
    Products :+public string one_High
    Products :+public string one_Retro
    From1<|-- From2
    From2 :-void pictureBox2_Click()
    From2 :-void pictureBox1_Click()
    From2 :-void pictureBox3_Click()
    From2 :-void pictureBox4_Click()
    From2 :-void pictureBox5_Click()
    From2 :-void pictureBox6_Click()
    From2 :-void countBuy_ValueChanged()
    From2 :-void buy_Click()
    From2 :-void back_Click()
    From1 :- void Chicago_Click()
    From1 :- void bt_Indigo_Click()
    From1 :- void bt_Cacao_Click()
    From1 :- void bt_JDsmoke_Click()
    From1 :- void bt_JDretro_Click()
    From1 :- void bt_byChicago_Click()
    From1 :- void bt_Indigo_Click()
    From1 :- void bt_Cacao_Click()
    From1 :- void bt_JDsmoke_Click()
    From1:- void bt_JDretro_Click() 
    From2 -- CSV
   
    class CSV{
      -string path
      +bool CSVfile
      
    }
```