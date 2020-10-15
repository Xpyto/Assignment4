using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    int[,] levelMap1 =
    {
    {1,2,2,2,2,2,2,2,2,2,2,2,2,7},{7,2,2,2,2,2,2,2,2,2,2,2,2,1},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,4},{4,5,5,5,5,5,5,5,5,5,5,5,5,2},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,4},{4,5,3,4,4,4,3,5,3,4,4,3,5,2},
    {2,6,4,0,0,4,5,4,0,0,0,4,5,4},{4,5,4,0,0,0,4,5,4,0,0,4,6,2},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,3},{3,5,3,4,4,4,3,5,3,4,4,3,5,2},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,5},{5,5,5,5,5,5,5,5,5,5,5,5,5,2},
    {2,5,3,4,4,3,5,3,3,5,3,4,4,4},{4,4,4,3,5,3,3,5,3,4,4,3,5,2},
    {2,5,3,4,4,3,5,4,4,5,3,4,4,3},{3,4,4,3,5,4,4,5,3,4,4,3,5,2},
    {2,5,5,5,5,5,5,4,4,5,5,5,5,4},{4,5,5,5,5,4,4,5,5,5,5,5,5,2},
    {1,2,2,2,2,1,5,4,3,4,4,3,0,4},{4,0,3,4,4,3,4,5,1,2,2,2,2,1},
    {0,0,0,0,0,2,5,4,3,4,4,3,0,3},{3,0,3,4,4,3,4,5,2,0,0,0,0,0},
    {0,0,0,0,0,2,5,4,4,0,0,0,0,0},{0,0,0,0,0,4,4,5,2,0,0,0,0,0},
    {0,0,0,0,0,2,5,4,4,0,3,4,4,0},{0,4,4,3,0,4,4,5,2,0,0,0,0,0},
    {2,2,2,2,2,1,5,3,3,0,4,0,0,0},{0,0,0,4,0,3,3,5,1,2,2,2,2,2},
    {0,0,0,0,0,0,5,0,0,0,4,0,0,0},{0,0,0,4,0,0,0,5,0,0,0,0,0,0},
    };

    int[,] levelMap2 = 
    {  
    {2,2,2,2,2,1,5,3,3,0,4,0,0,0},{0,0,0,4,0,3,3,5,1,2,2,2,2,2},
    {0,0,0,0,0,2,5,4,4,0,3,4,4,0},{0,4,4,3,0,4,4,5,2,0,0,0,0,0},
    {0,0,0,0,0,2,5,4,4,0,0,0,0,0},{0,0,0,0,0,4,4,5,2,0,0,0,0,0},
    {0,0,0,0,0,2,5,4,3,4,4,3,0,3},{3,0,3,4,4,3,4,5,2,0,0,0,0,0},
    {1,2,2,2,2,1,5,4,3,4,4,3,0,4},{4,0,3,4,4,3,4,5,1,2,2,2,2,1},
    {2,5,5,5,5,5,5,4,4,5,5,5,5,4},{4,5,5,5,5,4,4,5,5,5,5,5,5,2},
    {2,5,3,4,4,3,5,4,4,5,3,4,4,3},{3,4,4,3,5,4,4,5,3,4,4,3,5,2},
    {2,5,3,4,4,3,5,3,3,5,3,4,4,4},{4,4,4,3,5,3,3,5,3,4,4,3,5,2},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,5},{5,5,5,5,5,5,5,5,5,5,5,5,5,2},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,3},{3,5,3,4,4,4,3,5,3,4,4,3,5,2},
    {2,6,4,0,0,4,5,4,0,0,0,4,5,4},{4,5,4,0,0,0,4,5,4,0,0,4,6,2},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,4},{4,5,3,4,4,4,3,5,3,4,4,3,5,2},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,4},{4,5,5,5,5,5,5,5,5,5,5,5,5,2},
    {1,2,2,2,2,2,2,2,2,2,2,2,2,7},{7,2,2,2,2,2,2,2,2,2,2,2,2,1},
    };
    public GameObject[] sprites;

    // Start is called before the first frame update
    void Awake()
    {
        GenerateLevelup();
        GenerateLeveldown();
        
        
        Instantiate(sprites[7],new Vector3(13,0,0),Quaternion.identity);
        GameObject temp1 =  Instantiate(sprites[7],new Vector3(14,0,0),Quaternion.identity) as GameObject; 
        temp1.transform.localScale = new Vector3(-1,1,1);
        GameObject temp2 =  Instantiate(sprites[7],new Vector3(13,-28,0),Quaternion.identity) as GameObject; 
        temp2.transform.localScale = new Vector3(-1,-1,1);
        GameObject temp3 =  Instantiate(sprites[7],new Vector3(14,-28,0),Quaternion.identity) as GameObject; 
        temp3.transform.localScale = new Vector3(1,-1,1);         
        GenerateSprite(3,13,-4,90);
        GenerateSprite(3,14,-4,180); 

        //Brute forced weird corners
        GenerateSprite(3,13,-7,-90);    GenerateSprite(3,8,-19,0);
        GenerateSprite(3,8,-6,-90);     GenerateSprite(3,13,-24,0);
        GenerateSprite(3,19,-10,-90);   GenerateSprite(3,19,-19,-90);
        GenerateSprite(3,17,-12,-90);   GenerateSprite(3,14,-24,-90);
        GenerateSprite(3,14,-7,0);      GenerateSprite(3,8,-18,90);
        GenerateSprite(3,19,-6,0);      GenerateSprite(3,19,-22,90);
        GenerateSprite(3,8,-10,0);      GenerateSprite(3,19,-18,180);
        GenerateSprite(3,10,-12,0);     GenerateSprite(3,8,-22,180);
        GenerateSprite(3,8,-13,180);    GenerateSprite(3,10,-16,90);
        GenerateSprite(3,19,-9,180);    GenerateSprite(3,17,-16,180);
        GenerateSprite(3,7,-13,90);     GenerateSprite(3,11,-19,180);
        GenerateSprite(3,19,-13,90);    GenerateSprite(3,11,-18,-90);
        GenerateSprite(3,8,-9,90);      GenerateSprite(3,14,-18,-90);
        GenerateSprite(3,11,-10,180);   GenerateSprite(3,13,-18,0);
        GenerateSprite(3,11,-9,-90);    GenerateSprite(3,16,-18,0);
        GenerateSprite(3,14,-10,180);   GenerateSprite(3,16,-19,90);
        GenerateSprite(3,13,-10,90);    GenerateSprite(3,14,-21,90);
        GenerateSprite(3,16,-10,90);    GenerateSprite(3,13,-21,180);
        GenerateSprite(3,16,-9,0);
        GenerateSprite(3,20,-13,180);
    }

    void GenerateSprite(int num,int i, int j,int rot){
        Instantiate(sprites[num], new Vector3(i,j,0),Quaternion.Euler(0,0,rot));
    }

    void GenerateLevelup(){
        int i = 0; 
        int j = 0;
        foreach(int num in levelMap1){
            if(i == 28){ 
                i = 0;
                j--;
            }
            if(num == 1){
                if((i==0 && j==0)||(i==22&&j==-9)){
                    GenerateSprite(num,i,j,0);
                }else if((Mathf.Abs(i+j)==18)||(i==5 && j == -13)){
                    Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.Euler(0,0,180));
                }else if(Mathf.Abs(i+j)==9){
                    Instantiate(sprites[num],new Vector3(i,j,0), Quaternion.Euler(0,0,90));
                }else{
                    Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.Euler(0,0,270));
                }
            }
        

            if(num == 2){
                if(j==0 || j==-9 || j==-13){
                Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.Euler(0,0,90));
                 }else{
                GenerateSprite(num,i,j,0);
            }
            }

            if(num ==3){
                if(j==-2||j==-6){
                    if(i==2||i==7||i==10||i==16||i==22){
                     GenerateSprite(num,i,j,0);
                    }else if(i==5||i==11||i==17||i==20||i==25){
                    Instantiate(sprites[num],new Vector3(i,j,0), Quaternion.Euler(0,0,-90));
                    }
                }else if(j==-4||j==-7){
                    if(i==2||i==7||i==10||i==16||i==22){
                     Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.Euler(0,0,90));
                    }else if(i==5||i==11||i==17||i==20||i==25){
                    Instantiate(sprites[num],new Vector3(i,j,0), Quaternion.Euler(0,0,180));
                    }
                }
            }

            if(num == 4){
                if(j==-2||j==-4||j==-6||j==-7||j==-9||j==-10){
                    if((j==-2&&(i==13||i==14))||((j==-7)&&(i==7||i==8||i==19||i==20))||((j==-9||j==-10)&&(i==7||i==20||i==13||i==14))){
                        GenerateSprite(num,i,j,0);
                    }else{
                    Instantiate(sprites[num], new Vector3(i,j,0),Quaternion.Euler(0,0,90));
                    }
                }else if(j== -12){
                        if((i==7||i==8||i==19||i==20)){
                            GenerateSprite(num,i,j,0);
                        }else if(i==11||i==12||i==15||i==16){
                            GenerateSprite(num,i,j,90);
                        }
                }else{
                GenerateSprite(num,i,j,0);}
            }

            if(num == 5){
                GenerateSprite(num,i,j,0);
            }

            if(num == 6){
                GenerateSprite(num,i,j,0);
            }


           
            
            i++;
        }
    }

    void GenerateLeveldown(){
        int i = 0; 
        int j = -15;
        foreach(int num in levelMap2){
            if(i == 28){ 
                i = 0;
                j--;
            }
            if(num == 1){
                if(j==-19){
                    if(i==0){
                        GenerateSprite(num,i,j,0);
                    }else if(i==5){
                        GenerateSprite(num,i,j,180);
                    }else if(i!=27){
                        GenerateSprite(num,i,j,90);
                    }else{
                        GenerateSprite(num,i,j,-90);
                    }
                }else if(j==-28){
                    if(i==0){
                        GenerateSprite(num,i,j,90);
                    }else{
                        GenerateSprite(num,i,j,180);
                    }
                }else if(j==-15 && i==22){
                    GenerateSprite(num,i,j,0);
                }else{
                    GenerateSprite(num,i,j,-90);
                }
            }
        

            if(num == 2){
                if(j==-15 || j==-19 || j==-28){
                Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.Euler(0,0,90));
                 }else{
                GenerateSprite(num,i,j,0);
            }
            }

            if(num ==3){
                if(j==-26||j==-22){
                    if(i==2||i==7||i==10||i==16||i==22){
                     GenerateSprite(num,i,j,90);
                    }else if(i==5||i==11||i==17||i==20||i==25){
                    Instantiate(sprites[num],new Vector3(i,j,0), Quaternion.Euler(0,0,180));
                    }
                }else if(j==-24||j==-21){
                    if(i==2||i==7||i==10||i==16||i==22){
                     Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.Euler(0,0,0));
                    }else if(i==5||i==11||i==17||i==20||i==25){
                    Instantiate(sprites[num],new Vector3(i,j,0), Quaternion.Euler(0,0,-90));
                    }
                }
                if(j==-15){
                    if(i==7||i==19){
                        GenerateSprite(num,i,j,0);
                    }else{
                        GenerateSprite(num,i,j,-90);
                    }
                }
            }

            if(num == 4){
                if(j==-26||j==-24||j==-22||j==-21||j==-19||j==-18){
                    if((j==-26&&(i==13||i==14))||((j==-21)&&(i==7||i==8||i==19||i==20))||((j==-19||j==-18)&&(i==7||i==20||i==13||i==14))){
                        GenerateSprite(num,i,j,0);
                    }else{
                    Instantiate(sprites[num], new Vector3(i,j,0),Quaternion.Euler(0,0,90));
                    }
                }else if(j== -16){
                        if((i==7||i==8||i==19||i==20)){
                            GenerateSprite(num,i,j,0);
                        }else if(i==11||i==12||i==15||i==16){
                            GenerateSprite(num,i,j,90);
                        }
                }else{
                GenerateSprite(num,i,j,0);}
            }

            if(num == 5){
                GenerateSprite(num,i,j,0);
            }

            if(num == 6){
                GenerateSprite(num,i,j,0);
            }


           
            
            i++;
        }
    }

}
