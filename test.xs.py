import sys,math

class Main:
    def main():
        i=0
        print("Hello!")
        print("i : "+str(i))
        i+=1
        print("i : "+str(i))
        n=input("What\'s your name?")
        y=n.upper()
        x=n.lower()
        print(y+' '+x)
        input()
        l=99
        print(Main.test())
    def test():
        zz="Hello! Yes You!"
        ll=len(zz)
        return ll

w = Main.main()