//
//  NavigationBar.swift
//  amosity
//
//  Created by Adam Mason on 02/06/2023.
//

import SwiftUI

struct NavigationBar: View {
    var title = ""
    var SettingsTitle = ""
    var Searching = true
    var Settings = false
    let purple = UIColor(red: 0.09803921568627451, green: 0, blue: 0.19607843137254902, alpha: 1)
    @State private var showSettingsView = false
    @State var searchtxt:String = ""
    var body: some View {
        ZStack{
            ZStack{
                Color(purple)
                    //.opacity(0.1)
                    //.background(.ultraThinMaterial)
                    //.blur(radius: 10)
                    .frame(maxWidth: .infinity, minHeight: 25, maxHeight: .infinity, alignment: . leading)
                    .ignoresSafeArea()
                    .offset(CGSize(width: 0.0, height: 5.0))
                if Searching == false{
                    Text(title)
                        .font(Font.system(size: 30))
                        .frame(maxWidth: .infinity, alignment: .leading)
                        .padding(.leading, 15)
                        .offset(CGSize(width: 0.0, height: 10.0))
                        .foregroundStyle(Color(red: 0.8156862745098039, green: 0.8156862745098039, blue: 0.8156862745098039))
                        
                    }
                if Searching == true{
                    SearchableCustom(searchtxt: $searchtxt)
                        .frame(maxHeight: .infinity, alignment: .top)
                        //.background(.ultraThinMaterial)
                        .offset(CGSize(width: 0.0, height: 50.0))
                }
                if Settings == true{
                    Text(SettingsTitle)
                        .font(Font.system(size: 30))
                        .frame(maxWidth: .infinity, alignment: .leading)
                        .padding(.leading, 15)
                        .offset(CGSize(width: 0.0, height: 10.0))
                        .foregroundStyle(Color(red: 0.8156862745098039, green: 0.8156862745098039, blue: 0.8156862745098039))
                        Button(action: { showSettingsView = true }){
                            Image(systemName: "gear")
                                .resizable()
                                .frame(width: 32.0, height: 32.0,alignment: .trailing)
                                .scaledToFit()
                                .frame(alignment: .trailing)
                                .padding(.leading, 350)
                                .padding(.top, 20)

                        }
                        NavigationLink("", destination:  Settingsview(), isActive: $showSettingsView)

                            
                if Settings == false{
                    Text(title)
                        .font(Font.system(size: 30))
                        .frame(maxWidth: .infinity, alignment: .leading)
                        .padding(.leading, 15)
                        .offset(CGSize(width: 0.0, height: 10.0))
                        .foregroundStyle(.white)
                    }
                }
            }
            .frame(height: 115)
            .frame(maxHeight: .infinity, alignment: .top)
            .ignoresSafeArea()
        }
    }
}
struct NavigationBar_Previews: PreviewProvider {
    static var previews: some View {
        NavigationBar(title: "Pixly",Searching: false,Settings: false)
    }
}
