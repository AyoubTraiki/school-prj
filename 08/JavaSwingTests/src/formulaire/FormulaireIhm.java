package formulaire;
import java.awt.*;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;

public class FormulaireIhm {
private Frame f;
private Label nom,prenom, carte,cvv,ad1,ad2,suite1,suite2,ville1,ville2, zip1,zip2,pays1,pays2, adfact,adliv,chek;
private TextField tnom,tprenom, tcarte,tcvv,tad1,tad2,tsuite1,tsuite2,tville1,tville2, tzip1,tzip2,tpays1,tpays2,tch;
private Checkbox ch;
private Panel P,p1,p2,p3,p4,p5,p6,p7,p8;

public void afficher(){
	f=new Frame("formulaire d'inscription");
	nom=new Label("nom");
	prenom=new Label("prenom");
	carte=new Label("numéro de carte");
	cvv=new Label("cvv2");
	ad1=new Label("adresse");
	ad2=new Label("adresse");
	suite1=new Label("suite");
      suite2=new Label("suite");
      ville1=new Label("ville");
      ville2=new Label("ville");
      zip1=new Label("zip");
      zip2=new Label("zip");
      pays1=new Label("pays");
      pays2=new Label("pays");
      adfact=new Label("adresse de facturation");
      adliv=new Label("adresse de livraison");
      chek=new Label("meme que l'adresse de la facturation");
      
      tnom=new TextField(30);
      tprenom=new TextField(30);
      tcarte=new TextField(30);
      tcvv=new TextField(30);
      tad1=new TextField(30);
    tad2=new TextField(30);
      tsuite1=new TextField(30);
      tsuite2=new TextField(30);
      tville1=new TextField(30);
      tville2=new TextField(30);
      tzip1=new TextField(30);
      tzip2=new TextField(30);
      tpays1=new TextField(30);
      tpays2=new TextField(30);
      ch=new Checkbox();
      P=new Panel(new GridLayout(6,1));
      p1=new Panel();p2=new Panel();
      p3=new Panel();p4=new Panel();
      p5=new Panel(new GridLayout(1,2));
      p6=new Panel(new GridLayout(1,2));
      p7=new Panel(new GridLayout(5,2));
      p8=new Panel(new GridLayout(6,2));
      
    p1.add(nom);p1.add(tnom);
    p2.add(prenom);p2.add(tprenom);
    p3.add(carte);p3.add(tcarte);
    p4.add(cvv);p4.add(tcvv);
    p5.add(adfact);p5.add(adliv);
    p7.add(ad1);p7.add(tad1);
    p7.add(suite1);p7.add(tsuite1);
    p7.add(ville1);p7.add(tville1);
    p7.add(zip1);p7.add(tzip1);
    p7.add(pays1);p7.add(tpays1);
    
    p8.add(ad2);p8.add(tad2);
    p8.add(suite2);p8.add(tsuite2);
    p8.add(ville2);p8.add(tville2);
    p8.add(zip2);p8.add(tzip2);
    p8.add(pays2);p8.add(tpays2);
    p8.add(ch);p8.add(chek);
    p6.add(p7);p6.add(p8);
    
 P.add(p1);P.add(p2);P.add(p3);P.add(p4);P.add(p5);P.add(p6);
 f.add(P);
 f.setSize(400,600);
 f.setVisible(true);

 ch.addItemListener(new ItemListener(){public void itemStateChanged(ItemEvent e){
     Checkbox c=(Checkbox)e.getSource();
 if (c.getState()){
         tad2.setText(tad1.getText());
         tsuite2.setText(tsuite1.getText());
         tville2.setText(tville1.getText());
         tzip2.setText(tzip1.getText());
        tpays2.setText(tpays1.getText());
      }
 else {
     tad2.setText("");
     tsuite2.setText("");
     tville2.setText("");
     tzip2.setText("");
     tpays2.setText("");
}	
 }
	 });
    
    
     



}
public static void main(String[]args){FormulaireIhm f= new FormulaireIhm(); f.afficher();}
}

