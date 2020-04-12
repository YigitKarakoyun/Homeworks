#include <iostream>
using namespace std;
 
int adet = 10;
int adetYarisi = adet/2;
bool Get_OrtasiMi(int deger){
    if(deger==adetYarisi|| deger==adetYarisi-1) return true;
    return false;
}
bool Get_BasiMi(int deger){
    return deger==0;
}
bool Get_SonuMu(int deger){
    return (adet-1)==deger;
}
bool Get_Basi_Veya_SonuMu(int deger){
    return Get_BasiMi(deger) || Get_SonuMu(deger);
}
bool Get_Basamak_VarMi(int i,int j){
    return i==j || i-adetYarisi==adetYarisi-1-j;
    
}
int main () {
   char a[adet][adet];
   printf("Kare Çiziliyor");
   printf("\n\n");
   for ( int i = 0; i < adet; i++ ){
      for ( int j = 0; j < adet; j++ ) {
      
        if(Get_Basi_Veya_SonuMu(i) || Get_Basi_Veya_SonuMu(j)   
        )
        {
            a[i][j]='*';
            
        }
        else if( Get_OrtasiMi(i) && Get_OrtasiMi(j))
        {
             a[i][j]='*';
        }
        else
        {
             a[i][j]=' ';
        }
        printf("%c",a[i][j]);
      }
      printf("\n\n");
   }
   
   char b[adet][adetYarisi];
   printf("Merdiven Çiziliyor");
   printf("\n\n");
   for ( int i = 0; i < adet; i++ ){
      for ( int j = 0; j < adetYarisi; j++ ) {
      
        if(Get_Basamak_VarMi(i,j))
        {
            b[i][j]='*';
            
        }
        else
        {
             b[i][j]=' ';
        }
        printf("%c",b[i][j]);
      }
      printf("\n\n");
   }
   return 0;
}