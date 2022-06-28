import java.util.Comparator;

public class sxDonGia implements Comparator<GiaoDich> {
	@Override
	public int compare(GiaoDich gd1, GiaoDich gd2) {
		return (int) (gd1.donGia - gd2.donGia);
		
	}
}
