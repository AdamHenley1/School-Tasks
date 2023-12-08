//
//  DarkRoomView.swift
//  Pixly
//
//  Created by Adam Mason on 08/11/2023.
//

import SwiftUI

struct DarkRoomView: View {
    let purple = UIColor(red: 0.09803921568627451, green: 0, blue: 0.19607843137254902, alpha: 1)
    var columns = [GridItem(.adaptive(minimum: 160),spacing: 20)]
    var body: some View{
        NavigationStack{
            ScrollView(.vertical, showsIndicators: false) {
                LazyVGrid(columns: columns, spacing: 0){
                    //TempBox()
                    //TempBox()
                }
                .padding()
                .offset(x:0,y:100)
            }
                .overlay(
                    NavigationBar(title: "Dark Room",Searching: false, Settings: false)
                )
                .background(Color(purple))
                    .frame(minWidth: 0,maxWidth: .infinity, maxHeight: .infinity)
                    .ignoresSafeArea()
        }
    }
}

#Preview {
    DarkRoomView()
}
