package calculatrice;
import java.awt.Button;
import java.awt.Frame;
import java.awt.GridLayout;
import java.awt.Label;
import java.awt.Panel;
import java.awt.TextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
public class CalculatriceIhm {
	Frame f= new Frame();
	Button plus;
	Button moins;
	Button div;
	Button multi;
	Button sqrt;
	TextField tf1;
	TextField tf2;
	TextField tf3;
	Label l1;
	Label l2;
	Label l3;
	Panel p1;
	Panel p2;
	Panel p3;
	Panel p4;
	
	public void afficher(){
		p1=new Panel();tf1=new TextField();
		p2=new Panel();tf2=new TextField();
		p3=new Panel();tf3=new TextField();
		p4=new Panel();l1=new Label("op1");
		l2=new Label("op2");
		l3=new Label("resultat");
		plus=new Button("+");
		moins=new Button("-");
		multi=new Button("*");
		div=new Button("/");
		sqrt=new Button("sqrt");
		f=new Frame("Calculatrice");
		p1.add(l1); p1.add(tf1);
		p2.add(l2); p2.add(tf2);
		p3.add(plus); p3.add(moins);p3.add(multi);p3.add(div);
		p4.add(l3);
		p4.add(tf3);
		p4.add(sqrt);
		f.setLayout(new GridLayout(4,2));
		f.add(p1);
		f.add(p2);f.add(p3); f.add(p4);
		f.setSize(400,400);
		f.setVisible(true);
		plus.addActionListener(new ActionListener(){public void actionPerformed(ActionEvent e){
			double d1,d2;
			try {d1=Double.parseDouble(tf1.getText());
			d2=Double.parseDouble(tf2.getText());}catch(NumberFormatException e1){e1.printStackTrace();
			tf1.setText("Numerique"); return;}
			tf3.setText((d1+d2)+"");}});		
		moins.addActionListener(new ActionListener(){public void actionPerformed(ActionEvent e){
			double d1,d2;
			try {d1=Double.parseDouble(tf1.getText());
			d2=Double.parseDouble(tf2.getText());}catch(NumberFormatException e1){e1.printStackTrace();
			tf1.setText("Numerique"); return;}
			tf3.setText((d1-d2)+"");}});
		div.addActionListener(new ActionListener(){public void actionPerformed(ActionEvent e){
			double d1,d2;
			try {d1=Double.parseDouble(tf1.getText());
			d2=Double.parseDouble(tf2.getText());}catch(NumberFormatException e1){e1.printStackTrace();
			tf1.setText("Numerique"); return;}
			tf3.setText((d1/d2)+"");}});
		
		multi.addActionListener(new ActionListener(){public void actionPerformed(ActionEvent e){
			double d1,d2;
			try {d1=Double.parseDouble(tf1.getText());
			d2=Double.parseDouble(tf2.getText());}catch(NumberFormatException e1){e1.printStackTrace();
			tf1.setText("Numerique"); return;}
			tf3.setText((d1*d2)+"");}});
		
		sqrt.addActionListener(new ActionListener(){public void actionPerformed(ActionEvent e){
			try{
				tf3.setText(Math.sqrt(Double.parseDouble(tf3.getText()))+"");
			}catch(Exception e2){tf3.setText("error");}}});
		
			
		
		}
	
		public static void main(String[]ags){
			CalculatriceIhm F=new CalculatriceIhm();
			F.afficher();
		}
		

}
