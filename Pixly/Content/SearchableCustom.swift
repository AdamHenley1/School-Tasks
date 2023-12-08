//
//  SearchableCustom.swift
//  amosity
//
//  Created by Adam Mason on 11/10/2023.
//
import SwiftUI

struct SearchableCustom: View {
    
    @Binding var searchtxt: String
    @FocusState private var isSearchFocused: Bool // Track focus state
    
    var body: some View {
        HStack {
            HStack {
                Image(systemName: "paintbrush")
                TextField("Search :D", text: $searchtxt)
                    .focused($isSearchFocused) // Track focus state
                    .padding(.horizontal, 2)
                    .padding(.vertical, 8)
            }
            .padding(.horizontal)
            .background(.ultraThinMaterial)
            .cornerRadius(10)
            .overlay(RoundedRectangle(cornerRadius: 10).stroke(Color.gray, lineWidth: 1))
            
            if isSearchFocused {
                Button("Nope :(") {
                    searchtxt = ""
                    withAnimation(.spring()) {
                        isSearchFocused = false
                    }
                }
                .transition(.move(edge: .trailing)) // Add animation for cancel button
            }
        }
        .frame(maxWidth: .infinity)
        .padding(.horizontal, 20)
    }
}
struct SearchBarSM: View {
    
    @State var searchtxt:String = ""
    
    var body: some View {
        VStack {
            SearchableCustom(searchtxt: $searchtxt)
            
        }
        .frame(maxHeight: .infinity, alignment: .top)
        .preferredColorScheme(.dark)
    }
}
