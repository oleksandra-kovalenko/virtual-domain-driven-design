namespace VDDD

module Footer =

  open Fable.Helpers.React
  open Fable.Helpers.React.Props
  open VDDD.Types

  let render model dispatch =
    div [ Class "footer bg-gray-200" ]
      [ div [ ] [ str "Copyright © Virtual Domain-Driven Design"]
        
        div [ ] [ str "Developed by Kenny Baas-Schwegler & Marco Heimeshoff "]
        
        div [ Class "link p-2"
              OnClick (fun e -> e.stopPropagation() ; GoTo Code_of_conduct |> dispatch) ]
          [ str "Code of Conduct" ] ]  
