from django.urls import path

from .views import (
    todo_list,
    todo_detail,
    todo_create,
    todo_update,
    todo_delete,
)

app_name='todos'

urlpatterns=[
    path('', todo_list),
    path('create-task/', todo_create),
    path('<int:id>/', todo_detail),
    path('<int:id>/update-task/', todo_update),
    path('<int:id>/delete-task/', todo_delete),
]
