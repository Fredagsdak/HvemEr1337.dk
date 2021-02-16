import React from 'react';
import TextField from '@material-ui/core/TextField';
import Button from '@material-ui/core/Button';
import { Dispatch } from 'redux';
import { useDispatch } from 'react-redux';
import { addPost } from '../../store/action-creators';
import { useHistory } from 'react-router-dom';
import { Routes } from '../../shared/routes';

type Props = {
    savePost: (post: IPost | any) => void;
}

const AddPost: React.FC<Props> = ({ savePost }) => {
    const [post, setPost] = React.useState<IPost | {}>();
    const handlePostData = (e: React.FormEvent<HTMLTextAreaElement | HTMLInputElement>) => {
        setPost({
            ...post,
            [e.currentTarget.id]: e.currentTarget.value
        });
    }
    const history = useHistory();
    const addNewPost = (e: React.FormEvent) => {
        e.preventDefault();
        savePost(post);
        history.push(Routes.scoreBoard);
    }
    return <form onSubmit={addNewPost}>
        <TextField id="message" label="Message" onChange={handlePostData} />
        <Button type="submit" variant="contained" color="primary" disabled={post === undefined ? true : false}>
            Submit
    </Button>
    </form>
};

const Post1337: React.FC = () => {
    const dispatch: Dispatch<any> = useDispatch();
    const savePost = React.useCallback(
        (post: IPost) => dispatch(addPost(post)),
        [dispatch]
    );

    return <div>
        This is where you post 1337
        <AddPost savePost={savePost} />
    </div>
};

export default Post1337;