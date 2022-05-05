// $(document).ready(function(){
//     $(".like").click(function(){
//         $(this).toggleClass("heart");
//     })
// })

document.querySelector('.like').addEventListener('click', (e) => {
    e.currentTarget.classList.toggle('heart');
  });