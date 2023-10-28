﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    getDatatable('#table-funcionarios');
    getDatatable('#table-holerites');

    $('.btn-total-funcionarios').click(function () {
        var usuarioId = $(this).attr('usuario-id');

        $.ajax({
            type: 'GET',
            url: '/Usuario/ListarContatosPorUsuarioId/' + usuarioId, 
            success: function (result) {
                $("#listaFuncionarios").html(result);
                $('#modalFuncionarios').modal();
                getDatatable('#table-contatos-usuario');
            }
        });
    });
})

function getDatatable(id) {
    $(id).DataTable({
        "ordering": true,
        "paging": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado na tabela",
            "sInfo": "Mostrar _START_ at&eacute; _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrar 0 at&eacute; 0 de 0 Registros",
            "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros por pagina",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Proximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Ultimo"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }
    });
}


$('.close-alert').click(function () {
    $(".alert").hide('hide');
});


document.addEventListener('DOMContentLoaded', function () {
    var senha = document.getElementById('senha');
    var confirmarSenha = document.getElementById('confirmarSenha');

    function validarSenha() {
        if (senha.value !== confirmarSenha.value) {
            confirmarSenha.setCustomValidity('As senhas não coincidem');
        } else {
            confirmarSenha.setCustomValidity('');
        }
    }

    senha.addEventListener('change', validarSenha);
    confirmarSenha.addEventListener('keyup', validarSenha);
});


document.getElementById('cpfInput').addEventListener('input', function () {
    let cpf = this.value.replace(/\D/g, '');
    if (cpf.length > 3) {
        cpf = cpf.substring(0, 3) + '.' + cpf.substring(3);
    }
    if (cpf.length > 7) {
        cpf = cpf.substring(0, 7) + '.' + cpf.substring(7);
    }
    if (cpf.length > 11) {
        cpf = cpf.substring(0, 11) + '-' + cpf.substring(11, 14);
    }
    this.value = cpf;
});
